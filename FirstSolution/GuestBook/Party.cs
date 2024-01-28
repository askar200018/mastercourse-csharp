namespace GuestBook;

public static class Party
{

  public static void WelcomeGuests()
  {
    System.Console.WriteLine("Hi, Welcome to our party!!!");
  }

  public static string GetGuestName()
  {
    Console.Write("What's your name: ");
    string name = Console.ReadLine();
    return name;
  }

  public static int GetAmountOfGuests()
  {
    Console.Write("How many of you: ");
    string cntText = Console.ReadLine();
    int.TryParse(cntText, out int cnt);
    return cnt;
  }

  public static bool CheckIsDone()
  {
    Console.Write("Please type exit if you done: ");
    string text = Console.ReadLine();
    if (text == "exit")
    {
      return true;
    }
    return false;
  }

  public static void PrintInformation(List<string> guests, int totalOfGuests)
  {
    foreach (var guest in guests)
    {
      System.Console.WriteLine($"Guest {guest}");
    }

    System.Console.WriteLine($"The total of guest {totalOfGuests}");
  }

}
