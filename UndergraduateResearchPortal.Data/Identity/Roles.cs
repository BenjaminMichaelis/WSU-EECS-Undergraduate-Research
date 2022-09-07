namespace UndergraduateResearchPortal.Data.Identity;
internal class Roles
{
    public const string SuperAdmin = nameof(SuperAdmin);
    public const string User = nameof(User);

    public static readonly string[] AllRoles = new[]
    {
        SuperAdmin,
        User,
    };
}
