using System.ComponentModel.DataAnnotations;

namespace SimpleWasm.Models;

public class PersonModel
{

  [Required]
  [StringLength(10, MinimumLength = 5)]
  public string FirstName { get; set; }
  [Required]
  public string LastName { get; set; }
}
