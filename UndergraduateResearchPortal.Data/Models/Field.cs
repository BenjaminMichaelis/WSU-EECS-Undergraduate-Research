using IntelliTect.Coalesce.DataAnnotations;

namespace UndergraduateResearchPortal.Data.Models;
public class Field
{
    public Guid FieldId { get; set; }
    [ClientValidation(MinLength = 1, MaxLength = 50)]
    public string Name { get; set; }
}
