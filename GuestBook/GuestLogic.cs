namespace GuestBook;

public static class GuestLogic
{
  public static void WelcomeMessages()
  {
    System.Console.WriteLine("Hi, welcome to our party!!!");
    System.Console.WriteLine("Please help us fill some information");
    System.Console.WriteLine("************************************");
    System.Console.WriteLine();
  }

  public static string GetPartyName()
  {
    Console.Write("What's your group/party name: ");
    string output = Console.ReadLine();
    return output;
  }

  public static int GetPartySize()
  {
    int output;
    bool isValidNumber;

    do
    {
      Console.Write("How many people in there: ");
      string partySizeText = Console.ReadLine();
      isValidNumber = int.TryParse(partySizeText, out output);
    } while (!isValidNumber);

    return output;
  }

  public static bool AskToContinue()
  {
    Console.Write("Are there more guests? (yes/no): ");
    string continueLooping = Console.ReadLine();
    System.Console.WriteLine();

    bool output = continueLooping.ToLower() == "yes";
    return output;
  }

  public static (List<string> guests, int totalGuests) GetAllGuests()
  {
    List<string> guests = new List<string>();
    int totalGuests = 0;

    do
    {
      guests.Add(GetPartyName());
      totalGuests += GetPartySize();
    } while (AskToContinue());

    return (guests, totalGuests);
  }

  public static void DisplayGuests(List<string> guests)
  {
    foreach (string guest in guests)
    {
      System.Console.WriteLine(guest);
    }
  }

  public static void DisplayTotalGuests(int totalGuests)
  {
    System.Console.WriteLine("Thank you for attending this evening");
    System.Console.WriteLine($"The total number of guests was {totalGuests}");
  }
}
