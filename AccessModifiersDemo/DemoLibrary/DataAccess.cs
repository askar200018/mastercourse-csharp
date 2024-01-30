namespace DemoLibrary;

public class DataAccess
{
  protected internal string GetConnectionString()
  {
    Person person = new Person();
    return "Secure connection string";
  }
}
