//example of overriding method in C#
using System;
class Animal
{
    public virtual void Sound() 
    {
        Console.WriteLine("Animal makes a sound");
    }
}
class Dog : Animal // Derived class (inheriting from Animal)
{
    public override void Sound() // The body of Sound() is provided here
    {
        Console.WriteLine("The dog says: bark bark");
    }
}
class Cat : Animal // Derived class (inheriting from Animal)
{
    public override void Sound() // The body of Sound() is provided here
    {
        Console.WriteLine("The cat says: meow meow");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal myDog = new Dog(); // Create a Dog object
        Animal myCat = new Cat(); // Create a Cat object

        myDog.Sound(); // Call the overridden method
        myCat.Sound(); // Call the overridden method

        Console.WriteLine("This is how to show the overriding method in C#");
    }
}
