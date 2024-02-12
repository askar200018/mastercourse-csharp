using System.ComponentModel.DataAnnotations;

namespace MVCMiniProject.Models;

public class PersonModel
{
    [Required]
    [StringLength(10, MinimumLength = 5)]
    [Display(Name = "First Name Cool")]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public bool IsActive { get; set; }
}
