using InheritanceDemo;


// ****** PRO TIPS *********
// Inheritance seems like a magic cure but it is not.
// Use it sparingly and follow the "is a" rule.


List<Phone> phones = new List<Phone>();
phones.Add(new CellPhone());
phones.Add(new SmartPhone());

Console.ReadLine();

foreach (var phone in phones)
{
    if (phone is CellPhone cell)
    {
        cell.Carrier = "";
    }
    if (phone is SmartPhone smartPhone)
    {
        smartPhone.ConnectToInternet();
    }
}

public class Vehicle
{
    public int Speed { get; set; }
}
public class MororCycle : Vehicle { }
public class Boat : Vehicle { }
public class Car : Vehicle { }
