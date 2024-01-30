namespace InheritanceMiniProject;


public static partial class Program
{
  public class VehicleModel : InventoryItemModel, IPurchasable, IRentable
  {
    public int DealerFee { get; set; }

    public void Purchase()
    {
      QuantityInStock -= 1;
      System.Console.WriteLine("This vehicle has been purchased");
    }

    public void Rent()
    {
      QuantityInStock -= 1;
      System.Console.WriteLine("This vehicle has been rented");
    }

    public void ReturnRental()
    {
      QuantityInStock += 1;
      System.Console.WriteLine("This vehicle has been returned");
    }
  }
}