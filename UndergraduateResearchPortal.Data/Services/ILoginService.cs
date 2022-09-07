using IntelliTect.Coalesce;
using IntelliTect.Coalesce.DataAnnotations;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace UndergraduateResearchPortal.Data.Services;

[Coalesce, Service]
public interface ILoginService
{
    [Execute(PermissionLevel = SecurityPermissionLevels.AllowAll)]
    Task<ItemResult> Login(string email, string password);

    [Execute(PermissionLevel = SecurityPermissionLevels.AllowAll)]
    Task<ItemResult<dynamic>> GetToken(string email, string password);

    [Execute(PermissionLevel = SecurityPermissionLevels.AllowAll)]
    Task<ItemResult> Logout();

    [Execute(PermissionLevel = SecurityPermissionLevels.AllowAll)]
    Task<ItemResult> CreateAccount(string firstName, string lastName, string email, string password);

    [Execute(PermissionLevel = SecurityPermissionLevels.AllowAuthorized)]
    Task<ItemResult> ChangePassword(ClaimsPrincipal user, string currentPassword, string newPassword);

    [Execute(PermissionLevel = SecurityPermissionLevels.AllowAll)]
    ItemResult IsLoggedIn(ClaimsPrincipal user);
}
