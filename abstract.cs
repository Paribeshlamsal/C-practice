//give an example of abstract class
//and abstract method
// Abstract class and method example in C#
using System;
abstract class Animal
{
    public abstract void Sound(); // Abstract method (does not have a body)
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

        myDog.Sound(); // Call the abstract method
        myCat.Sound(); // Call the abstract method

        Console.WriteLine("This is how to show the abstract class and method in C#");
    }
}