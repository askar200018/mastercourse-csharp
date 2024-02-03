

using StandardLibrary;

Generators generators = new Generators();
PersonModel person = new PersonModel
{
    FirstName = "Tim",
    LastName = "Corey",
    Prefix = "Mr."
};

string message = generators.WelcomeMessage(person.Prefix, person.FirstName);

System.Console.WriteLine(message);