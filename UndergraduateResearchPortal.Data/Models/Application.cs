using IntelliTect.Coalesce.DataAnnotations;

namespace UndergraduateResearchPortal.Data.Models;
public class Application
{
    public Guid ApplicationId { get; set; }
    public User User { get; set; }
    [ClientValidation(IsRequired = true, MinLength = 1, MaxLength = 100)]
    public string PreferredName { get; set; }
    [ClientValidation(IsRequired = true, MinLength = 1, MaxLength = 1500)]
    public string Description { get; set; }
    [ClientValidation(IsRequired = true, MinLength = 1, MaxLength = 50)]
    public string ReferenceName { get; set; }
    [ClientValidation(IsRequired = true, MinLength = 1, MaxLength = 50)]
    public string ReferenceEmail { get; set; }
    public bool ApprovedForInterview { get; set; } = false;
    public bool Hired { get; set; } = false;
    public bool NotHired { get; set; } = false;

}
