
// Interface is a contract
// Classes implement interfaces

// ******** PRO TIP *********
// Interfaces are a contract. 
// Use them as types when you need common functionality.

Console.ReadLine();

public interface IRun
{
    void Run();
}

public class Person : IRun
{
    public void Run()
    {
    }
}

public class Animal : IRun
{
    public void Run()
    {
    }
}