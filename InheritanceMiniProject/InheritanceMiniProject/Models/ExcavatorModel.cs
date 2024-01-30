namespace InheritanceMiniProject;


public static partial class Program
{
  public class ExcavatorModel : InventoryItemModel, IRentable
  {
    public void Dig()
    {
      System.Console.WriteLine("I am digging");
    }
    public void Rent()
    {
      QuantityInStock -= 1;
      System.Console.WriteLine("This excavator has been rented");
    }

    public void ReturnRental()
    {
      QuantityInStock += 1;
      System.Console.WriteLine("This excavator has been returned");
    }
  }
}