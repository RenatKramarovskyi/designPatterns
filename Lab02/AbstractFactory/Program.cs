using System;
using AbstractFactory.AbstractProducts;
using AbstractFactory.Factories;

namespace AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Task 2");

       IAbstractFactory balaxyFactory = new BalaxyFactory();
       IAbstractFactory kiaomiFactory = new KiaomiFactory();

       ISmartphone[] smartphones =
       {
           balaxyFactory.CreateSmartphone(7.5, "Android", 4, 32),
           kiaomiFactory.CreateSmartphone(8, "Android", 8, 126)
       };

       ILaptop[] laptops =
       {
           //double diagonal, string os, string ram, string cpu, string gpu
           balaxyFactory.CreateLaptop(15.6, "Windows", "2 x 8gb kingston", "R5 3600", "gtx 1050"),
           kiaomiFactory.CreateLaptop(15.6, "Windows", "2 x 8gb kingston", "R5 5500", "gtx 1650")
       };

       IDevice[] myDevices =
       {
           //double maxVolume, string formFactor, string[] features
           balaxyFactory.CreateSmartphone(7.5, "Android", 8, 256),
           kiaomiFactory.CreateLaptop(15.6, "Windows", "2 x 8gb kingston", "R5 5500", "gtx 1650"),
           kiaomiFactory.CreateHeadphones(40.5, "On ear", new string[] {"noise reduction", "bass boost", "bluetooth connectivity"} )
       };

       Console.WriteLine("\n=================\n");
       foreach (var smartphone in smartphones)
       {
           Console.WriteLine(smartphone);
       }
       Console.WriteLine("\n=================\n");
       foreach (var laptop in laptops)
       {
           Console.WriteLine(laptop);
       }
       Console.WriteLine("\n======= My devices (to be honest, no) ==========\n");
       foreach (var device in myDevices)
       {
           Console.WriteLine(device);
       }
    }
}