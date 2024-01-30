// See https://aka.ms/new-console-template for more information
using DemoLibrary;

public class CEO : Manager
{
  public void SayHi()
  {
    ModifiedDataAccess data = new ModifiedDataAccess();
    data.GetUnsecureConnection();
  }
}