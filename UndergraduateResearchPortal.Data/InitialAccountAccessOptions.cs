using System.ComponentModel.DataAnnotations;

namespace UndergraduateResearchPortal.Data;

public class InitialAccountAccessOptions : IUndergraduateResearchPortalOptions
{
    public virtual string Section => "InitialAccount";

    [Required]
    public string? Email { get; set; }
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public string? Password { get; set; }
}
