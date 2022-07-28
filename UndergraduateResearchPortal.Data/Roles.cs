namespace UndergraduateResearchPortal.Data;

public static class Roles
{
    /// <summary>
    /// An admin to the site
    /// </summary>
    public const string SuperAdmin = nameof(SuperAdmin);
    /// <summary>
    /// An admin to the site
    /// </summary>
    public const string Admin = nameof(Admin);

    /// <summary>
    /// A user who has access to create new postings to the site
    /// </summary>
    public const string Faculty = nameof(Faculty);

    /// <summary>
    /// A normal user on the site
    /// </summary>
    public const string User = nameof(User);

    public static readonly string[] AllRoles = new[]
    {
        SuperAdmin,
        Admin,
        Faculty,
        User
    };
}
