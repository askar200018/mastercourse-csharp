namespace OOPOne;

public class CalculateData
{
    public static double Add(double x, double y)
    {
        double output = x + y;
        return output;
    }

    public static double Substract(double x, double y)
    {
        double output = x - y;
        return output;
    }

    public static double Multiply(double x, double y)
    {
        double output = x * y;
        return output;
    }

    public static double Divide(double x, double y)
    {
        double output;
        try
        {
            output = x / y;
        }
        catch (System.Exception)
        {
            throw new ArgumentException("You can't divide to zero");
        }
        return output;
    }
    public static double SquareRoot(double x)
    {
        return Math.Sqrt(x);
    }
}
