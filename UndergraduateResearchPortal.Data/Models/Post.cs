using IntelliTect.Coalesce.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace UndergraduateResearchPortal.Data.Models;

#nullable disable
public class Post
{
    public int PostID { get; set; }

    [ClientValidation(IsRequired = true, MinLength = 1, MaxLength = 150)]
    public string Title { get; set; }
    [ClientValidation(IsRequired = true, MinLength = 1, MaxLength = 1500)]
    public string Description { get; set; }
    [Required]
    public DateTime StartDate { get; set; }
    [Required]
    public DateTime EndDate { get; set; }
    [Required]
    public int TimeCommitment { get; set; }
    [ClientValidation(IsRequired = true, MinLength = 1, MaxLength = 1500)]
    public string Qualifications { get; set; }
    public User User { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.Now;
#nullable restore
}
