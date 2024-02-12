using System.ComponentModel.DataAnnotations;

namespace MVCMiniProject.Models;

public class AddressModel
{
    [Required]
    public string City { get; set; }
    [Required]
    public string Street { get; set; }
    [Required]
    [Display(Name = "Zip Code")]
    public string ZipCode { get; set; }
}
