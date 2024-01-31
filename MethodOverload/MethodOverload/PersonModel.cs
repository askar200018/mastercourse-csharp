
// *********** PRO TIP ***********
// Overloads make things easier for the user.
// Behind the scenes, just make sure you keep your code DRY.

// Console.ReadLine();


public class PersonModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public PersonModel()
    {
    }
    public PersonModel(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public PersonModel(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void GenerateEmail()
    {
        GenerateEmail("aol.com", false);
    }
    public void GenerateEmail(string domain)
    {
        GenerateEmail(domain, false);
    }
    public void GenerateEmail(bool firstInitialMethod)
    {
        GenerateEmail("aol.com", firstInitialMethod);
    }
    public void GenerateEmail(string domain, bool firstInitialMethod)
    {
        if (firstInitialMethod)
        {
            Email = $"{FirstName.Substring(0, 1)}.{LastName}.${domain}";
        }
        else
        {
            Email = $"{FirstName}.{LastName}.${domain}";
        }
    }
}