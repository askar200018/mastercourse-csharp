// ******** PRO TIP *********
// Extension methods make it easier to read your code.


// "Hello World".PrintToConsole();

// HotelRoomModel room = new HotelRoomModel();
// room.TurnOnAir().SetTemperature(23).OpenShades();
// room.TurnOffAir().CloseShades();


public static class ExtensionSamples
{

    public static PersonModel SetDefaultAge(this PersonModel person)
    {
        person.Age = 21;
        return person;
    }
    public static PersonModel PrintInfo(this PersonModel person)
    {
        System.Console.WriteLine($"{person.FirstName} {person.LastName}, age is {person.Age}");
        return person;
    }

    public static void PrintToConsole(this string message)
    {
        System.Console.WriteLine(message);
    }

    public static HotelRoomModel TurnOnAir(this HotelRoomModel room)
    {
        room.IsAirRunning = true;
        return room;
    }
    public static HotelRoomModel TurnOffAir(this HotelRoomModel room)
    {
        room.IsAirRunning = false;
        return room;
    }

    public static HotelRoomModel SetTemperature(this HotelRoomModel room, int temperature)
    {
        room.Temperature = temperature;
        return room;
    }

    public static HotelRoomModel OpenShades(this HotelRoomModel room)
    {
        room.AreShadesOpen = true;
        return room;
    }
    public static HotelRoomModel CloseShades(this HotelRoomModel room)
    {
        room.AreShadesOpen = false;
        return room;
    }
}

