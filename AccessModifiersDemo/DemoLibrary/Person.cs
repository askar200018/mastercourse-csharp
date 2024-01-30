namespace DemoLibrary;

public class Person
{
  protected string formerLastName;
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public void SayHello()
  {
    System.Console.WriteLine($"Hello {FirstName}");
  }

  public void SetNewLastName(string newLastName)
  {
    formerLastName = LastName;
    LastName = newLastName;
  }
}
