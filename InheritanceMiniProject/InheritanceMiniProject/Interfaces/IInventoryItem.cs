namespace InheritanceMiniProject;


public static partial class Program
{
  public interface IInventoryItem
  {
    public string ProductName { get; set; }
    public int QuantityInStock { get; set; }
  }
}