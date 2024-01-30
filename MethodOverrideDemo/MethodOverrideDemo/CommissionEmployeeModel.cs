

// PersonModel
// EmployeeModel
// CommissionEmployeeModel


public class CommissionEmployeeModel : EmployeeModel
{
  public decimal CommissionAmount { get; set; }

  public override decimal GetPayCheck(decimal workedHours)
  {
    decimal initialPay = base.GetPayCheck(workedHours);
    return initialPay + CommissionAmount;
  }
}