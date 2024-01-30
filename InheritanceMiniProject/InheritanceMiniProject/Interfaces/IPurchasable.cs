namespace InheritanceMiniProject;


public static partial class Program
{
  public interface IPurchasable : IInventoryItem
  {
    void Purchase();
  }
}