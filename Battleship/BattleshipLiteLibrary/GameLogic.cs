using BattleshipLiteLibrary.Models;

namespace BattleshipLiteLibrary;

public static class GameLogic
{
    public static int CountShots()
    {
        throw new NotImplementedException();
    }

    public static object GetCountShot(PlayerInfoModel winner)
    {
        return winner.ShotGrid.Count(s => s.Status != GridSpotStatus.Empty);
    }

    public static bool IdentifyShotResult(PlayerInfoModel player, string row, int column)
    {

        bool isAHit = false;

        foreach (var ship in player.ShipLocations)
        {
            if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
            {
                isAHit = true;
                ship.Status = GridSpotStatus.Sank;
            }
        }

        return isAHit;

        // GridSpotModel gridSPot = player.ShipLocations.Find(s => s.SpotLetter == row && s.SpotNumber == column);

        // if (gridSPot == null)
        // {
        //     return false;
        // }

        // if (gridSPot.Status == GridSpotStatus.Ship)
        // {
        //     gridSPot.Status = GridSpotStatus.Sank;
        //     return true;
        // }
        // return false; ;
    }

    public static void InitializeGrid(PlayerInfoModel model)
    {
        List<string> letters = new List<string> { "A", "B", "C", "D", "E" };
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        foreach (var letter in letters)
        {
            foreach (var number in numbers)
            {
                AddGridSpot(model, letter, number);
            }
        }
    }

    public static bool IsPlayerStillAlive(PlayerInfoModel player)
    {
        bool isAlive = false;
        foreach (var ship in player.ShipLocations)
        {
            if (ship.Status == GridSpotStatus.Ship)
            {
                isAlive = true;
            }
        }
        return isAlive;
        // return opponent.ShipLocations.Any(s => s.Status == GridSpotStatus.Ship);
    }

    public static void MarkShotResult(PlayerInfoModel player, string row, int column, bool isAHit)
    {
        foreach (var gridSpot in player.ShotGrid)
        {
            if (gridSpot.SpotLetter == row.ToUpper() && gridSpot.SpotNumber == column)
            {
                if (isAHit)
                {
                    gridSpot.Status = GridSpotStatus.Hit;
                }
                else
                {
                    gridSpot.Status = GridSpotStatus.Miss;
                }
            }
        }

        // GridSpotModel gridSPot = activePlayer.ShotGrid.Find(s => s.SpotLetter == row && s.SpotNumber == column);
        // if (isAHit)
        // {
        //     gridSPot.Status = GridSpotStatus.Hit;
        // }
        // else
        // {
        //     gridSPot.Status = GridSpotStatus.Miss;
        // }
    }

    public static bool PlaceShip(PlayerInfoModel model, string location)
    {
        bool output = false;
        (string row, int column) = SplitCellIntoRowAndColumn(location);

        bool isValidSpot = ValidateSpot(row, column);
        bool isValidShipLocaiton = ValidateShipLocation(model, row, column);

        if (isValidSpot && isValidShipLocaiton)
        {
            model.ShipLocations.Add(new GridSpotModel
            {
                SpotLetter = row,
                SpotNumber = column,
                Status = GridSpotStatus.Ship
            });
            output = true;
        }

        return output;
    }

    private static bool ValidateShipLocation(PlayerInfoModel model, string row, int column)
    {
        bool isValidShipLocation = true;
        foreach (var ship in model.ShipLocations)
        {
            if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
            {
                isValidShipLocation = false;
            }
        }
        return isValidShipLocation;
    }

    private static bool ValidateSpot(string row, int column)
    {
        string rows = "ABCDE";
        if (column < 1 || column > 5) { return false; }
        if (!rows.Contains(row)) { return false; };
        return true;
    }

    public static (string row, int column) SplitCellIntoRowAndColumn(string cell)
    {
        if (cell.Length != 2)
        {
            throw new ArgumentException("Length of cell not correct");
        }
        string row = cell.Substring(0, 1).ToUpper();
        int column = int.Parse(cell.Substring(1));
        return (row, column);
    }

    public static bool ValidateShot(PlayerInfoModel player, string row, int column)
    {
        bool isValidShot = false;
        foreach (var gridSpot in player.ShotGrid)
        {
            if (gridSpot.SpotLetter == row.ToUpper() && gridSpot.SpotNumber == column)
            {
                if (gridSpot.Status == GridSpotStatus.Empty)
                {
                    isValidShot = true;
                }
            }
        }
        return isValidShot;
        // bool isValidSpot = ValidateSpot(row, column);
        // if (!isValidSpot)
        // {
        //     return isValidSpot;
        // }
        // GridSpotModel gridSPot = activePlayer.ShotGrid.Find(s => s.SpotLetter == row && s.SpotNumber == column);
        // return gridSPot.Status == GridSpotStatus.Empty;
    }

    private static void AddGridSpot(PlayerInfoModel model, string letter, int number)
    {
        GridSpotModel gridSpot = new GridSpotModel
        {
            SpotLetter = letter,
            SpotNumber = number,
            Status = GridSpotStatus.Empty
        };
        model.ShotGrid.Add(gridSpot);
    }
}
