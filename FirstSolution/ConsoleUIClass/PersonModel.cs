namespace ConsoleUIClass;

public class PersonModel
{

    public string FirstName { private get; set; }
    public string LastName { get; private set; }

    private int _age;
    public int Age
    {
        get { return _age; }
        set
        {
            if (value >= 0 && value < 200)
            {
                _age = value;
            }
        }
    }

    private string _password;
    public string Password
    {
        set { _password = value; }
    }

    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }

    private string _ssn;
    public string SSN
    {
        get
        {
            // 123-45-6789
            string output = $"***-**-{_ssn.Substring(_ssn.Length - 4)}";
            return output;
        }
        set { _ssn = value; }
    }

    public PersonModel() { }

    public PersonModel(string lastName)
    {
        LastName = lastName;
    }
}

