namespace HelloWorld;

public static class ConsoleMessages
{
  public static void SayHi(string firstName)
  {
    System.Console.WriteLine($"Hello {firstName}");
    System.Console.WriteLine("I hope you having a good day.");
  }

  public static string GetUserName()
  {
    Console.Write("What's your name: ");
    string name = Console.ReadLine();
    return name;
  }

  public static (string firstName, string lastName) GetFullName()
  {
    Console.Write("What's your first name: ");
    string firstName = Console.ReadLine();
    Console.Write("What's your last name: ");
    string lastName = Console.ReadLine();
    return (firstName, lastName);
  }


  public static (bool isValid, int num) OwnTryParse(string s)
  {
    bool isValid = int.TryParse(s, out int num);
    return (isValid, num);
  }

  public static void SayGoodbye()
  {
    System.Console.WriteLine("Goodbye, user!");
    System.Console.WriteLine("See you later.");
  }

  // HOMEWORK METHODS

  public static void Welcome()
  {
    System.Console.WriteLine("Welcome to our app");
  }

  public static string AskUserName()
  {
    System.Console.Write("What's your name: ");
    string name = Console.ReadLine();
    return name;
  }

  public static void SayHelloUser(string name)
  {
    System.Console.WriteLine($"Hello {name}");
  }
}
