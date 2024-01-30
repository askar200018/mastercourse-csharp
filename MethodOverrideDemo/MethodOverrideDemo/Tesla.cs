

// PersonModel
// EmployeeModel
// CommissionEmployeeModel


public class Tesla : Car
{
  public override void SetClock()
  {
    System.Console.WriteLine("Automatically set in Tesla");
  }

  public override void StartCar()
  {
    System.Console.WriteLine("Think about your destination");
  }
}