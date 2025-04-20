//create a base class vehicle derive the classes car, truck, and motorcycle from it. each derive class should add specific method relevant to that vehicle type.

using System;

class Vehicle
{
    public void start()
    {
        Console.WriteLine("Vehicle started.");
    }
}

class Car : Vehicle
{
    public void play_music()
    {
        Console.WriteLine("Playing music in the car.");
    }
}

class Truck : Vehicle
{
    public void load_cargo()
    {
        Console.WriteLine("Loading cargo into the truck.");
    }
}

class Motorcycle : Vehicle
{
    public void do_wheelie()
    {
        Console.WriteLine("Motorcycle is doing a wheelie!");
    }
}

class Program
{
    static void Main()
    {
        // Car object
        Car car = new Car();
        car.start();
        car.play_music();

        // Truck object
        Truck truck = new Truck();
        truck.start();
        truck.load_cargo();

        // Motorcycle object
        Motorcycle bike = new Motorcycle();
        bike.start();
        bike.do_wheelie();
    }
}
