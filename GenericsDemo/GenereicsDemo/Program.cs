
// ******** PRO TIP *********
// The standard generic variable is T
// but you can choose any letter you want.

// string result = FizzBuzz<string>("ABC");
// System.Console.WriteLine($"ABC: {result}");

// result = FizzBuzz<int>(12345);
// System.Console.WriteLine($"12345: {result}");

// result = FizzBuzz<bool>(true);
// System.Console.WriteLine($"true: {result}");


// result = FizzBuzz<PersonModel>(new PersonModel());
// System.Console.WriteLine($"PersonModel: {result}");


GenericHelper<PersonModel> personHelper = new GenericHelper<PersonModel>();
personHelper.CheckItemAndAdd(new PersonModel { FirstName = "Tim", HasError = true });
personHelper.CheckItemAndAdd(new PersonModel { FirstName = "Bob", HasError = false });


foreach (var item in personHelper.RejectedItems)
{
    System.Console.WriteLine($"{item.FirstName} {item.LastName} was rejected");
}

foreach (var item in personHelper.Items)
{
    System.Console.WriteLine($"{item.FirstName} {item.LastName} was good");
}


string FizzBuzz<T>(T item)
{
    string output = "";
    int itemLength = item.ToString().Length;
    if (itemLength % 3 == 0)
    {
        output += "Fizz";
    }
    if (itemLength % 5 == 0)
    {
        output += "Buzz";
    }
    return output;
}

public class GenericHelper<T> where T : IErrorCheck
{
    public List<T> Items { get; set; } = new List<T>();
    public List<T> RejectedItems { get; set; } = new List<T>();

    public void CheckItemAndAdd(T item)
    {
        if (!item.HasError)
        {
            Items.Add(item);
        }
        else
        {
            RejectedItems.Add(item);
        }
    }
}

public interface IErrorCheck
{
    bool HasError { get; set; }
}

public class Car : IErrorCheck
{
    public string Manufacturer { get; set; }
    public int YearManufactured { get; set; }
    public bool HasError { get; set; }
}

public class PersonModel : IErrorCheck
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool HasError { get; set; }
}