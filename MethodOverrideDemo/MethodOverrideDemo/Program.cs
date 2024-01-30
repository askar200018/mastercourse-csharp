
// ******** PRO TIP ***********
// If you are overriding every method,
// maybe you just needed an interface.

PersonModel person = new PersonModel
{
  FirstName = "Tim",
  LastName = "Corey",
  Email = "tim@iamtimcorey.com"
};

EmployeeModel employee = new EmployeeModel
{
  FirstName = "Bob",
  LastName = "Johns",
  Email = "bob@gmail.com",
  HourlyRate = 20,
};

Console.WriteLine(person);
Console.WriteLine(employee);
