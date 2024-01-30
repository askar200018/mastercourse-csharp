namespace InheritanceMiniProject;


// ************** PRO TIP ****************
// Just because you can doesn't mean you should.
// Know why are you doing something before doing it.

public static partial class Program
{
  public static void Main(string[] args)
  {

    List<IPurchasable> purchasables = new List<IPurchasable>();
    List<IRentable> rentables = new List<IRentable>();

    var vehicle = new VehicleModel { ProductName = "Kia Optima", QuantityInStock = 10, DealerFee = 110 };
    var book = new BookModel { ProductName = "Atomic Habits", NumberOfPages = 350, QuantityInStock = 5 };
    var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStock = 3 };


    purchasables.Add(book);
    purchasables.Add(vehicle);

    rentables.Add(vehicle);
    rentables.Add(excavator);

    Console.Write("Hi, What do you want (rent/purchase): ");
    string rentalDecision = Console.ReadLine();

    if (rentalDecision.ToLower() == "rent")
    {
      foreach (var item in rentables)
      {
        Console.WriteLine($"Item: {item.ProductName}");
        Console.Write($"Do you want to rent this item (yes/no): ");
        string wantToRent = Console.ReadLine();
        if (wantToRent == "yes")
        {
          item.Rent();
        }

        Console.Write("Do you want to return this item (yes/no): ");
        string wantToReturn = Console.ReadLine();
        if (wantToReturn.ToLower() == "yes")
        {
          item.ReturnRental();
        }
      }
    }
    else
    {
      foreach (var item in purchasables)
      {
        Console.WriteLine($"Item: {item.ProductName}");
        Console.Write("Do you want to purchase this item(yes/no): ");
        string wantToPurchase = Console.ReadLine();

        if (wantToPurchase.ToLower() == "yes")
        {
          item.Purchase();
        }
      }
    }

    Console.ReadLine();
  }
}