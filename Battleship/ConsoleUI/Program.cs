

using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;

// **** PRO TIP *******
// UI-specific code should not live in a class library
// unless the library is for that UI type.

// Get your code working first but then evaluate
// if you can refactor anything to make it more DRY.

// Don't just test the "happy path".
// Try to break your application.
// Your users will if you don't.

WelcomeMessages();

PlayerInfoModel activePlayer = CreatePlayer("Player 1");
PlayerInfoModel opponent = CreatePlayer("Player 2");
PlayerInfoModel winner = null;


do
{
    DisplayShotGrid(activePlayer);

    RecordPlayerShot(activePlayer, opponent);

    bool doesGameContinue = GameLogic.IsPlayerStillAlive(opponent);
    if (doesGameContinue)
    {
        (activePlayer, opponent) = (opponent, activePlayer);
    }
    else
    {
        winner = activePlayer;
    }

} while (winner == null);


CongratulateWinner(winner);

void CongratulateWinner(PlayerInfoModel winner)
{
    Console.WriteLine($"Congratulations, you are winner {winner.UsersName}");
    System.Console.WriteLine($"You took {GameLogic.GetCountShot(winner)} shots");
}

void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
{
    bool isValidShot = false;
    string row = "";
    int column = 0;
    do
    {
        string shot = AskForShot(activePlayer.UsersName);

        try
        {
            (row, column) = GameLogic.SplitCellIntoRowAndColumn(shot);
            isValidShot = GameLogic.ValidateShot(activePlayer, row, column);
        }
        catch (System.Exception ex)
        {

            isValidShot = false; ;
        }


        if (!isValidShot)
        {
            System.Console.WriteLine("Invalid location! Please try again.");
        }
    } while (!isValidShot);

    bool isAHit = GameLogic.IdentifyShotResult(opponent, row, column);
    GameLogic.MarkShotResult(activePlayer, row, column, isAHit);
    DisplayShotResult(row, column, isAHit);

}

void DisplayShotResult(string row, int column, bool isAHit)
{
    if (isAHit)
    {
        System.Console.WriteLine($"{row}{column} is a Hit!");
    }
    else
    {
        System.Console.WriteLine($"{row}{column} is a miss.");
    }
    System.Console.WriteLine();
}

static string AskForShot(string usersName)
{
    Console.Write($"{usersName} Please enter your shot selection: ");
    string output = Console.ReadLine();
    return output;
}

static void DisplayShotGrid(PlayerInfoModel activePlayer)
{
    string currentRow = activePlayer.ShotGrid[0].SpotLetter;
    foreach (var gridSpot in activePlayer.ShotGrid)
    {
        if (currentRow != gridSpot.SpotLetter)
        {
            Console.WriteLine();
            currentRow = gridSpot.SpotLetter;
        }
        if (gridSpot.Status == GridSpotStatus.Empty)
        {
            Console.Write($" {gridSpot.SpotLetter}{gridSpot.SpotNumber} ");
        }
        else if (gridSpot.Status == GridSpotStatus.Hit)
        {
            System.Console.Write(" X  ");
        }
        else if (gridSpot.Status == GridSpotStatus.Miss)
        {
            System.Console.Write(" O  ");
        }
        else
        {
            System.Console.Write(" ?  ");
        }
        // Another way of line break
        // if (spot.SpotNumber % 5 == 0)
        // {
        //     Console.ReadLine();
        // }
    }

    System.Console.WriteLine();
    System.Console.WriteLine();

}

static void WelcomeMessages()
{
    System.Console.WriteLine("Welcome to Battleship Lite app!");
    System.Console.WriteLine("Created by Askar Imangali");
    System.Console.WriteLine();
}


static PlayerInfoModel CreatePlayer(string playerTitle)
{
    System.Console.WriteLine($"Please fill information for: {playerTitle}");

    PlayerInfoModel output = new PlayerInfoModel();

    output.UsersName = AskForUsersName();

    GameLogic.InitializeGrid(output);

    PlaceShips(output);

    Console.Clear();

    return output;
}

static string AskForUsersName()
{
    System.Console.Write("What is your name: ");
    string output = Console.ReadLine();
    return output;
}

static void PlaceShips(PlayerInfoModel model)
{
    do
    {
        Console.Write($"Where to place your {model.ShipLocations.Count + 1} ship : ");
        string location = Console.ReadLine();

        bool isValid = false;
        try
        {
            isValid = GameLogic.PlaceShip(model, location);
        }
        catch (System.Exception)
        {

            isValid = false;
        }


        if (!isValid)
        {
            Console.WriteLine("Please try again with a valid spot");
        }

    } while (model.ShipLocations.Count < 5);
}

