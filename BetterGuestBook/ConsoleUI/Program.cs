using GuestBookLibrary.Models;


// ******* PRO TIP ***********
// Design your app with just UI content in the UI.
// Put everything else in a Class Library.

namespace ConsoleUI
{
    class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();

        static void Main(string[] args)
        {
            GetGuestInformation();

            PrintGuestInformation();

            Console.ReadLine();
        }

        private static void PrintGuestInformation()
        {
            foreach (var guest in guests)
            {
                System.Console.WriteLine(guest.GuestInfo);
            }
        }


        private static void GetGuestInformation()
        {
            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GetInfoFromConsole("What is your first name: ");
                guest.LastName = GetInfoFromConsole("What is your last name: ");
                guest.Age = GetIntegerFromConsole("What is your age: ");
                guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host: ");
                moreGuestsComing = GetInfoFromConsole("Are more guests coming(yes/no): ");

                guests.Add(guest);

                Console.Clear();

            } while (moreGuestsComing.ToLower() == "yes");
        }

        private static string GetInfoFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }

        private static int GetIntegerFromConsole(string message)
        {
            int output;
            bool isValidInt = false;

            Console.Write(message);

            do
            {
                string text = Console.ReadLine();
                isValidInt = int.TryParse(text, out output);

                if (!isValidInt)
                {
                    Console.Write("You wrote invalid number, please try again: ");
                }
            } while (!isValidInt);

            return output;
        }
    }
}
