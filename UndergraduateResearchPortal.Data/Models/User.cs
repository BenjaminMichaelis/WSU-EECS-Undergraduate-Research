using IntelliTect.Coalesce.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace UndergraduateResearchPortal.Data.Models;

#nullable disable
public class User : IdentityUser
{
    [ClientValidation(IsRequired = true, MinLength = 1, MaxLength = 100)]
    public string FirstName { get; set; }
    [ClientValidation(IsRequired = true, MinLength = 1, MaxLength = 100)]
    public string LastName { get; set; }
    [ClientValidation(IsRequired = true, MinLength = 8, MaxLength = 8)]
    public int WSUId { get; set; }
    [ClientValidation(MinLength = 3, MaxLength = 30)]
    public string Major { get; set; }
    [ClientValidation(MinLength = 1, MaxLength = 100)]
    public string GraduationDate { get; set; }
    [ClientValidation(MinLength = 1, MaxLength = 4)]
    public float GPA { get; set; }
    [ClientValidation(MinLength = 1, MaxLength = 1500)]
    public string Experience { get; set; }
    [ClientValidation(MinLength = 1, MaxLength = 1500)]
    public string ElectiveCourses { get; set; }
    [ListText]
    [NotMapped]
    public string Name => FirstName + " " + LastName;
#nullable restore
}