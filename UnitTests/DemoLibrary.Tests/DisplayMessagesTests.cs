namespace DemoLibrary.Tests;

// Arrange, Act, Assert
// expected and actual
public class DisplayMessagesTests
{
    [Fact]
    public void GreetingShouldReturnGoodMorningMessage()
    {
        // Arrange
        DisplayMessages messages = new DisplayMessages();
        string expected = "Good morning Tim";

        // Act
        string actual = messages.Greeting("Tim", 5);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GreetingShouldReturnGoodAfternoonMessage()
    {
        // Arrange
        DisplayMessages messages = new DisplayMessages();
        string expected = "Good afternoon Tim";

        // Act
        string actual = messages.Greeting("Tim", 15);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Tim", 0, "Go to bed Tim")]
    [InlineData("Tim", 1, "Go to bed Tim")]
    [InlineData("Tim", 2, "Go to bed Tim")]
    [InlineData("Tim", 3, "Go to bed Tim")]
    [InlineData("Tim", 4, "Go to bed Tim")]
    [InlineData("Tim", 5, "Good morning Tim")]
    [InlineData("Tim", 6, "Good morning Tim")]
    [InlineData("Tim", 7, "Good morning Tim")]
    [InlineData("Tim", 8, "Good morning Tim")]
    [InlineData("Tim", 9, "Good morning Tim")]
    [InlineData("Tim", 10, "Good morning Tim")]
    [InlineData("Tim", 11, "Good morning Tim")]
    [InlineData("Tim", 12, "Good afternoon Tim")]
    [InlineData("Tim", 13, "Good afternoon Tim")]
    [InlineData("Tim", 14, "Good afternoon Tim")]
    [InlineData("Tim", 15, "Good afternoon Tim")]
    [InlineData("Tim", 16, "Good afternoon Tim")]
    [InlineData("Tim", 17, "Good afternoon Tim")]
    [InlineData("Tim", 18, "Good evening Tim")]
    [InlineData("Tim", 19, "Good evening Tim")]
    [InlineData("Tim", 20, "Good evening Tim")]
    [InlineData("Tim", 21, "Good evening Tim")]
    [InlineData("Tim", 22, "Good evening Tim")]
    [InlineData("Tim", 23, "Good evening Tim")]
    public void GreetingShouldReturnExpectedMessage(
        string firstName,
        int hourOfTheDay,
        string expected)
    {
        DisplayMessages messages = new DisplayMessages();

        // Act
        string actual = messages.Greeting(firstName, hourOfTheDay);

        // Assert
        Assert.Equal(expected, actual);
    }


    [Theory]
    [InlineData(1, "1 AM")]
    [InlineData(9, "9 AM")]
    [InlineData(18, "6 PM")]
    [InlineData(22, "10 PM")]
    public void ConvertToTwelveHourShouldReturnExpectedMessage(int hourOfTheDay, string expected)
    {

        // Arrange
        DisplayMessages messages = new DisplayMessages();

        // Act
        string actual = messages.ConvertToTwelveHour(hourOfTheDay);

        // Assert
        Assert.Equal(expected, actual);
    }

}


