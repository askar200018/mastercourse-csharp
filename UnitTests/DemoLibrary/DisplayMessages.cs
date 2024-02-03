namespace DemoLibrary;

// ********** PRO TIP ************
// Testing is an up-front expense for a long-term ROI
// in safety, confidence and stability.

// Arrange, Act, Assert
// Red, Green, Refactor
public class DisplayMessages
{
    public string Greeting(string firstName, int hourOfTheDay)
    {
        string output = "";
        if (hourOfTheDay < 5)
        {
            output = $"Go to bed {firstName}";
        }
        else if (hourOfTheDay < 12)
        {
            output = $"Good morning {firstName}";
        }
        else if (hourOfTheDay < 18)
        {
            output = $"Good afternoon {firstName}";
        }
        else
        {
            output = $"Good evening {firstName}";
        }
        return output;
    }

    public string ConvertToTwelveHour(int hourOfTheDay)
    {
        string output = "";
        if (hourOfTheDay < 12)
        {
            output = $"{hourOfTheDay} AM";
        }
        else
        {
            output = $"{hourOfTheDay - 12} PM";
        }
        return output;
    }
}
