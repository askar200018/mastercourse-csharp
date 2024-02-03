namespace MathLibrary;


// ********* PRO TIP *************
// Test more than just the perfect case.
// Test all of the imperfect cases most of all.

public class MathOperations
{
    public double Add(double x, double y)
    {
        return x + y;
    }

    public double Substract(double x, double y)
    {
        return x - y;
    }

    public double Multiply(double x, double y)
    {
        return x * y;
    }

    public double Divide(double x, double y)
    {
        double output = 0;

        if (y != 0)
        {
            output = x / y;
        }
        return output;
    }

}
