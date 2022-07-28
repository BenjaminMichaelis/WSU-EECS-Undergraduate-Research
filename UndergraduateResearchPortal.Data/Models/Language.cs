using IntelliTect.Coalesce.DataAnnotations;

namespace UndergraduateResearchPortal.Data.Models;
public class Language
{
    public Guid LanguageId { get; set; }
    [ClientValidation(IsRequired = true, MinLength = 1, MaxLength = 20)]
    public string Name { get; set; }
}
