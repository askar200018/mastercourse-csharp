namespace OOPOne;

public class RequestData
{

    public static string GetAString(string message)
    {
        Console.Write(message);
        string output = Console.ReadLine();
        return output;
    }

    public static double GetADouble(string message)
    {
        Console.Write(message);

        double output;
        bool isValid;
        do
        {
            string numberText = Console.ReadLine();
            isValid = double.TryParse(numberText, out output);
            if (!isValid)
            {
                System.Console.Write("That was not a valid number. Please try again ");
            }

        } while (!isValid);

        return output;
    }

}
