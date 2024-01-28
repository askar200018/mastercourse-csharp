using OOPOne;

// string firstName = RequestData.GetAString("What's your name: ");
// UserMessages.ApplicationStartMessage(firstName);


// double x = RequestData.GetADouble("Please enter your first number: ");
// double y = RequestData.GetADouble("Please enter your second number: ");

// double result = CalculateData.Add(x, y);
// UserMessages.DisplayResult($"The result of adding {x} + {y} is equal to {result}");

// double sqrOfRoot = CalculateData.SquareRoot(81);
// System.Console.WriteLine(sqrOfRoot);

// *************PRO TIP***********
// Use class files to separate your code so
// that each class and each method has 
// its own purpose.




List<PersonModel> people = new List<PersonModel>();

string firstName;
do
{
    Console.Write("What's your first name (or type exit to stop): ");
    firstName = Console.ReadLine();
    Console.Write("What's your last name: ");
    string lastName = Console.ReadLine();
    Console.Write("What's city are you from: ");
    string city = Console.ReadLine();

    if (firstName.ToLower() != "exit")
    {
        PersonModel person = new PersonModel();
        person.FirstName = firstName;
        person.LastName = lastName;
        AddressModel address = new AddressModel();
        address.City = city;
        person.HomeAddress = address;
        people.Add(person);
    }


} while (firstName.ToLower() != "exit");

foreach (PersonModel p in people)
{
    ProcessPerson.GreetPerson(p);
}

// *********** PRO TIP ***********
// In general, instantiated classes store data.
// Static classes are for stateless processing.

Console.ReadLine();