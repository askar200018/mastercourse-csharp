namespace OOPOne;

public class UserMessages
{
    public static void ApplicationStartMessage(string name)
    {
        Console.Clear();
        System.Console.WriteLine("Welcome to UserMessages Demo App");

        int hourOfDay = DateTime.Now.Hour;

        if (hourOfDay < 12)
        {
            System.Console.WriteLine($"Good morning {name}!");
        }
        else if (hourOfDay < 19)
        {
            System.Console.WriteLine($"Good afternoon {name}!");
        }
        else
        {
            System.Console.WriteLine($"Good evening {name}!");
        }
    }

    public static void DisplayResult(string message)
    {
        System.Console.WriteLine(message);
        System.Console.WriteLine();
        System.Console.WriteLine("Thank you for using our Calulcation App");
    }
}
