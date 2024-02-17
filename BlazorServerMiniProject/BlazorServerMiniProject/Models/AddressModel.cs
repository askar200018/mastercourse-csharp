using System.ComponentModel.DataAnnotations;

namespace BlazorServerMiniProject.Models;

public class AddressModel
{
    [Required]
    public string City { get; set; }
    [Required]
    public string Street { get; set; }
    [Required]
    public string ZipCode { get; set; }
}
