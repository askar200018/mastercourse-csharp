namespace BattleshipLiteLibrary.Models;


// ********** PRO TIP **************
// Separating your non-UI code into a class library
// means you can reuse your code more easily. 

public class PlayerInfoModel
{
    public string UsersName { get; set; }
    public List<GridSpotModel> ShipLocations { get; set; } = new List<GridSpotModel>();
    public List<GridSpotModel> ShotGrid { get; set; } = new List<GridSpotModel>();
}
