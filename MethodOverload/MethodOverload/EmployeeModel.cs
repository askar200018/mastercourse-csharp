
// *********** PRO TIP ***********
// Overloads make things easier for the user.
// Behind the scenes, just make sure you keep your code DRY.

public class EmployeeModel : PersonModel
{
    public decimal HourlyRate { get; set; }
    public string Position { get; set; }

    public EmployeeModel()
    {
    }
    public EmployeeModel(decimal hourlyRate)
    {
        HourlyRate = hourlyRate;
    }
    public EmployeeModel(string position)
    {
        Position = position;
    }
    public EmployeeModel(string firstName, string lastName, string position, decimal hourlyRate) : base(firstName, lastName)
    {
        HourlyRate = hourlyRate;
        Position = position;
    }
}