//example of downcasting in C#
using System;
class Animal
{
    public void Sound() 
    {
        Console.WriteLine("Animal makes a sound");
    }
}
class Dog : Animal // Derived class (inheriting from Animal)
{
    public void Bark() // The body of Bark() is provided here
    {
        Console.WriteLine("The dog says: bark bark");
    }
}
class Cat : Animal // Derived class (inheriting from Animal)
{
    public void Meow() // The body of Meow() is provided here
    {
        Console.WriteLine("The cat says: meow meow");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Dog(); // Upcasting: Dog object is treated as Animal
        myAnimal.Sound(); // Call the method from the base class

        // Downcasting: Cast the Animal reference back to Dog
        Dog myDog = (Dog)myAnimal; // Downcasting
        myDog.Bark(); // Call the method from the derived class

        Console.WriteLine("This is how to show the downcasting in C#");
    }
}
