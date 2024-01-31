
// Interface is a contract
// Classes implement interfaces

// ******** PRO TIP *********
// Interfaces are a contract. 
// Use them as types when you need common functionality.

public class Keyboard : IComputerController
{
    public void Connect() { }
    public void CurrentKeyPressed() { }
}
