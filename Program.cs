using LabPolymorphism;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Device> devices = new List<Device>
        {
            new Smartphone("Samsung Galaxy", 15),
            new Laptop("Dell Inspiron", 65),
            new Tablet("iPad", 20)
        };

        Console.WriteLine("=== Увімкнення електронних пристроїв ===");

        foreach (var device in devices)
        {
            device.TurnOn();
        }

        Console.ReadKey();
    }
}
