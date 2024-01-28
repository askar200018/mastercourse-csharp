namespace HelloWorld;

public static class MathShortcuts
{
  public static double Add(double x, double y)
  {
    // Console.WriteLine($"Sum of {x} and {y} equals to {x + y}");
    double output = x + y;
    return output;
  }

  public static double AddAll(double[] numbers)
  {
    double output = 0;

    foreach (var num in numbers)
    {
      output += num;
    }
    // Console.WriteLine($"Sum of numbers {output}");
    return output;
  }
}
