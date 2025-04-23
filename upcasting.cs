//example of upcasting in C#
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
        Animal myDog = new Dog(); // Upcasting: Dog object is treated as Animal
        Animal myCat = new Cat(); // Upcasting: Cat object is treated as Animal

        myDog.Sound(); // Call the method from the base class
        myCat.Sound(); // Call the method from the base class

        // The following lines would cause a compile-time error because the methods are not defined in the base class
        // myDog.Bark(); 
        // myCat.Meow(); 

        Console.WriteLine("This is how to show the upcasting in C#");
    }
}
