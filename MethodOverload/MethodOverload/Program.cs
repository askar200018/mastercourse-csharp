
// *********** PRO TIP ***********
// Overloads make things easier for the user.
// Behind the scenes, just make sure you keep your code DRY.

var person = new PersonModel(
    "Tim",
    "Corey"
);
var employee = new EmployeeModel();
person.GenerateEmail("@gmail.com");
System.Console.WriteLine(person.Email);
