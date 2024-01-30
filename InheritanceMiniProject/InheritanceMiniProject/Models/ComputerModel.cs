namespace InheritanceMiniProject;



public static partial class Program
{
  public class ComputerModel : InventoryItemModel, IPurchasable
  {
    public int Memory { get; set; }

    public void Purchase()
    {
      QuantityInStock -= 1;
      System.Console.WriteLine("This computer has been purchased");
    }
  }
}