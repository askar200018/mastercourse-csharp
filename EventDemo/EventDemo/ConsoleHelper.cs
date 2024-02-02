
// ********** PRO TIP ***********
// Use events to let others know about state change
// or other significant events.

public static class ConsoleHelper
{
    public static void PrintToConsole(this string message)
    {
        System.Console.WriteLine(message);
    }
}
