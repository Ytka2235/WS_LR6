using System;

class Program
{
    static void Main(string[] args)
    {
        Sedan sedan = new Sedan();
        PassengerPlane plane = new PassengerPlane();
        CargoShip ship = new CargoShip();

        Console.WriteLine(sedan.GetInfo());
        Console.WriteLine(plane.GetInfo());
        Console.WriteLine(ship.GetInfo());
    }
}

abstract class Transport
{
    public abstract int Speed { get; }
    public abstract int LoadCapacity { get; }
    public abstract int Distance { get; }

    public abstract string GetInfo();
}

abstract class Car : Transport
{
    public override int Speed => 180;
    public override int LoadCapacity => 500;
    public override int Distance => 800;
    
}

abstract class Airplane : Transport
{
    public override int Speed => 900;
    public override int LoadCapacity => 2000;
    public override int Distance => 5000;
}

abstract class Ship : Transport
{
    public override int Speed => 30;
    public override int LoadCapacity => 10000;
    public override int Distance => 3000;
    
}

class Sedan : Car
{
    public override string GetInfo()
    {
        return $"Sedan грузоподъемностью в {LoadCapacity} может проехать {Distance}";
    }

}

class PassengerPlane : Airplane
{
    public override string GetInfo()
    {
        return $"PassengerPlane грузоподъемностью в {LoadCapacity} может пролететь {Distance}";
    }
}

class CargoShip : Ship
{
    public override string GetInfo()
    {
        return $"CargoShip грузоподъемностью в {LoadCapacity} может проплыть {Distance}";
    }
}


