namespace DemoLibrary;

public class Manager : Employee
{
  public string GetFullName()
  {
    DataAccess data = new DataAccess();
    return $"{FirstName} {LastName} {formerLastName}";
  }
}
