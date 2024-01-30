namespace InheritanceMiniProject;


public static partial class Program
{
  public class BookModel : InventoryItemModel, IPurchasable
  {
    public int NumberOfPages { get; set; }

    public void Purchase()
    {
      QuantityInStock -= 1;
      System.Console.WriteLine("This book has been purchased");
    }
  }
}