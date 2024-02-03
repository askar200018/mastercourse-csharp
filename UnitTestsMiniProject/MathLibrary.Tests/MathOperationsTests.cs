namespace MathLibrary.Tests;

public class MathOperationsTests
{

    [Theory]
    [InlineData(10, 5, 15)]
    [InlineData(30, 4, 34)]
    [InlineData(0, -5, -5)]
    public void AddShouldReturnExpectedResult(double x, double y, double expected)
    {
        MathOperations mathOperations = new MathOperations();

        double actual = mathOperations.Add(x, y);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(10, 5, 5)]
    [InlineData(30, 4, 26)]
    [InlineData(0, -5, 5)]
    public void SubstractShouldReturnExpectedResult(double x, double y, double expected)
    {
        MathOperations mathOperations = new MathOperations();

        double actual = mathOperations.Substract(x, y);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(10, 5, 50)]
    [InlineData(30, 4, 120)]
    [InlineData(0, -5, 0)]
    public void MultiplyShouldReturnExpectedResult(double x, double y, double expected)
    {
        MathOperations mathOperations = new MathOperations();

        double actual = mathOperations.Multiply(x, y);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(10, 5, 2)]
    [InlineData(30, 4, 7.5)]
    [InlineData(0, -5, 0)]
    [InlineData(8, 0, 0)]
    public void DivideShouldReturnExpectedResult(double x, double y, double expected)
    {
        MathOperations mathOperations = new MathOperations();

        double actual = mathOperations.Divide(x, y);

        Assert.Equal(expected, actual);
    }
}
