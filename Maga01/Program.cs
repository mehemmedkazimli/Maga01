using System;
using System.Collections.Generic;
//Task3
class Vehicle
{
    public string Brand;
    public int Speed;

    public virtual void MakeSound()
    {
        Console.WriteLine(Brand + "ses çıxar");
    }
}

class Car : Vehicle
{
    public override void MakeSound()
    {
        Console.WriteLine(Brand + " maşın sesi: Beep beep");
    }
}

class Motorcycle : Vehicle
{
    public override void MakeSound()
    {
        Console.WriteLine(Brand + "motor sesi:Vroom vroom");
    }
}

class Bicycle : Vehicle
{
    public override void MakeSound()
    {
        Console.WriteLine(Brand + " velo sesi: Ring ring!");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();
        car.Brand = "BMW";
        car.Speed = 260;

        Motorcycle motorcycle = new Motorcycle();
        motorcycle.Brand = "Cruiser";
        motorcycle.Speed = 120;

        Bicycle bicycle = new Bicycle();
        bicycle.Brand = "M";
        bicycle.Speed = 20;

        List<Vehicle> vehicles = new List<Vehicle>();
        vehicles.Add(car);
        vehicles.Add(motorcycle);
        vehicles.Add(bicycle);

        foreach (Vehicle v in vehicles)
        {
            v.MakeSound();
        }
    }
}