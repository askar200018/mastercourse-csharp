
// ******** PRO TIP ********
// Generics and Events can make your code 
// more flexible to future changes.

partial class Program
{
    public static void Main(string[] args)
    {
        List<PersonModel> people = new List<PersonModel> {
            new PersonModel{ FirstName = "Tim", LastName = "Coreyheck", Email = "tim@corey.com"},
            new PersonModel{ FirstName = "Sue", LastName = "Smith", Email = "s@gmail.com"},
            new PersonModel{ FirstName = "Dandy", LastName = "Jokic", Email = "dandy1222@aol.com"},
        };

        List<CarModel> cars = new List<CarModel> {
            new CarModel{ Manufacturer = "Toyota", Model = "Camrydarnin" },
            new CarModel{ Manufacturer = "Toyota", Model = "Corolla" },
            new CarModel{ Manufacturer = "Kia", Model = "Rio" },
        };

        DataAccess<PersonModel> peopleData = new DataAccess<PersonModel>();
        peopleData.BadEntryFound += People_BadEntryFound;
        peopleData.SaveToCSV("people.CSV", people);

        DataAccess<CarModel> carsData = new DataAccess<CarModel>();
        carsData.BadEntryFound += Cars_BadEntryFound;
        carsData.SaveToCSV("cars.CSV", cars);

        // DataAccess.SaveToCSV("cars.CSV", cars);
    }

    private static void Cars_BadEntryFound(object sender, CarModel e)
    {
        System.Console.WriteLine($"{e.Manufacturer} {e.Model} has bad words");
    }

    private static void People_BadEntryFound(object sender, PersonModel e)
    {
        System.Console.WriteLine($"{e.FirstName} {e.LastName} has bad words");
    }
}

public class DataAccess<T> where T : new()
{
    public event EventHandler<T> BadEntryFound;
    public void SaveToCSV(string filePath, List<T> items)
    {
        List<string> rows = new List<string>();
        T entry = new T();
        var cols = entry.GetType().GetProperties();
        string row = "";
        foreach (var col in cols)
        {
            row += $",{col.Name}";
        }
        row = row.Substring(1);
        rows.Add(row);

        foreach (var item in items)
        {
            row = "";
            bool hasBadWord = false;
            foreach (var col in cols)
            {
                var value = col.GetValue(item).ToString();
                hasBadWord = BadWordDetector(value);

                if (hasBadWord)
                {
                    BadEntryFound?.Invoke(this, item);
                    break;
                }
                row += $",{value}";
            }
            if (!hasBadWord)
            {
                row = row.Substring(1);
                rows.Add(row);
            }
        }

        File.WriteAllLines(filePath, rows);
    }

    public bool BadWordDetector(string word)
    {
        bool output = false;
        string lowerCaseWord = word.ToLower();
        if (lowerCaseWord.Contains("heck") || lowerCaseWord.Contains("darn"))
        {
            output = true;
        }
        return output;
    }
}