

// PersonModel
// EmployeeModel
// CommissionEmployeeModel


public class EmployeeModel : PersonModel
{
  public decimal HourlyRate { get; set; }
  public virtual decimal GetPayCheck(decimal workedHours)
  {
    return workedHours * HourlyRate;
  }

  public override string ToString()
  {
    return $"{base.ToString()} with hourlyRate {HourlyRate}";
  }
}
