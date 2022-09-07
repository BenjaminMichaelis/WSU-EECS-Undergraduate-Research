using IntelliTect.Coalesce;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using UndergraduateResearchPortal.Data;
using UndergraduateResearchPortal.Data.Identity;
using UndergraduateResearchPortal.Data.Models;
using UndergraduateResearchPortal.Data.Services;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    Args = args,
    // Explicit declaration prevents ASP.NET Core from erroring if wwwroot doesn't exist at startup:
    WebRootPath = "wwwroot"
});

var configuration = builder.Configuration;

builder.Logging
    .AddConsole()
    // Filter out Request Starting/Request Finished noise:
    .AddFilter<ConsoleLoggerProvider>("Microsoft.AspNetCore.Hosting.Diagnostics", LogLevel.Warning);

builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();

#region Configure Services

var services = builder.Services;

services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), opt => opt
        .EnableRetryOnFailure()
        .UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
    ));

services.AddIdentity<User, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<AppDbContext>()
    .AddTokenProvider<DataProtectorTokenProvider<User>>(TokenOptions.DefaultProvider)
    .AddClaimsPrincipalFactory<UserClaimsPrincipalFactory<User, IdentityRole>>();

services.AddCoalesce<AppDbContext>();
services.AddSwaggerGen();

services
    .AddMvc()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });

services.Configure<InitialAccountAccessOptions>(configuration.GetSection("InitialAccount"));

JwtConfiguration jwtConfiguration = builder.Configuration.GetSection("JwtConfig").Get<JwtConfiguration>();
services.AddSingleton(jwtConfiguration);

services.AddAuthentication(auth =>
{
    auth.DefaultScheme = "JWT_OR_COOKIE";
    // set to null so the default scheme takes effect (was changed by .AddIdentity)
    auth.DefaultChallengeScheme = auth.DefaultAuthenticateScheme = null;
}).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtConfiguration.Issuer,
        ValidAudience = jwtConfiguration.Audience,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfiguration.SigningKey)),
    };
    options.SaveToken = true;
    options.Events = new JwtBearerEvents
    {

        OnMessageReceived = context =>
        {
            var path = context.Request.Path;
            // Pull the token from the querystring if it is present there.
            context.Token = context.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            if (context.Request.QueryString.Value?.Contains("token") ?? false)
                context.Token = context.Request.Query.Where(q => q.Key == "token").First().Value;

            return Task.CompletedTask;
        },
    };
}).AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
{
    options.Events.OnRedirectToLogin = c =>
    {
        c.Response.StatusCode = StatusCodes.Status401Unauthorized;
        return Task.FromResult<object>(null!);
    };
}).AddPolicyScheme("JWT_OR_COOKIE", "JWT_OR_COOKIE", options =>
{
    // runs on each request
    options.ForwardDefaultSelector = context =>
    {
        // use jwt if there is a token set
        string authorization = context.Request.Headers[HeaderNames.Authorization];
        if (!string.IsNullOrEmpty(authorization) && !authorization.Contains("null"))
            return JwtBearerDefaults.AuthenticationScheme;

        // otherwise always check for cookie auth
        return IdentityConstants.ApplicationScheme;
    };
});

services.AddScoped<ILoginService, LoginService>();

#endregion



#region Configure HTTP Pipeline

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

    app.UseViteDevelopmentServer(c =>
    {
        c.DevServerPort = 5002;
    });

    app.MapCoalesceSecurityOverview("coalesce-security");
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

var containsFileHashRegex = new Regex(@"\.[0-9a-fA-F]{8}\.[^\.]*$", RegexOptions.Compiled);
app.UseStaticFiles(new StaticFileOptions
{
    OnPrepareResponse = ctx =>
    {
        // vite puts 8-hex-char hashes before the file extension.
        // Use this to determine if we can send a long-term cache duration.
        if (containsFileHashRegex.IsMatch(ctx.File.Name))
        {
            ctx.Context.Response.GetTypedHeaders().CacheControl =
                new CacheControlHeaderValue { Public = true, MaxAge = TimeSpan.FromDays(30) };
        }
    }
});

// For all requests that aren't to static files, disallow caching by default.
// Individual endpoints may override this.
app.Use(async (context, next) =>
{
    context.Response.GetTypedHeaders().CacheControl =
        new CacheControlHeaderValue { NoCache = true, NoStore = true, };

    await next();
});

app.MapControllers();

// API fallback to prevent serving SPA fallback to 404 hits on API endpoints.
app.Map("/api/{**any}", () => Results.NotFound());

app.MapFallbackToController("Index", "Home");

#endregion



#region Launch

// Initialize/migrate database.
using (var scope = app.Services.CreateScope())
{
    var serviceScope = scope.ServiceProvider;

    // Run database migrations.
    using var db = serviceScope.GetRequiredService<AppDbContext>();
    db.Initialize();

    //var initialAccountOptions = serviceScope.GetRequiredService<IOptions<InitialAccountAccessOptions>>();
    //if (!db.Users.Any())
    //{
    //    var superAdminAccount = new User()
    //    {
    //        Email = initialAccountOptions.Value.Email,
    //        UserName = initialAccountOptions.Value.Email,
    //        FirstName = initialAccountOptions.Value.FirstName,
    //        LastName = initialAccountOptions.Value.LastName,
    //    };
    //    UserManager<User>? userManager = serviceScope.GetService<UserManager<User>>();


    //    userManager?.CreateAsync(superAdminAccount, initialAccountOptions.Value.Password).GetAwaiter().GetResult();
    //    userManager?.AddToRoleAsync(superAdminAccount, Roles.Admin).GetAwaiter().GetResult();
    //}
}

app.Run();

#endregion
