using System.ComponentModel.DataAnnotations;

namespace SimpleWasm;

public class Person
{

  [Required]
  [StringLength(10, MinimumLength = 5)]
  public string FirstName { get; set; }
  [Required]
  public string LastName { get; set; }
}
