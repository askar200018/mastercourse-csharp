namespace OOPOne;

public class ProcessPerson
{
    public static void GreetPerson(PersonModel person)
    {
        System.Console.WriteLine($"{person.FirstName} {person.LastName}, city is {person.HomeAddress.City}");
        person.HasGreeted = true;
    }
}
