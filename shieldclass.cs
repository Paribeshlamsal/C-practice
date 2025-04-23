//example of shield class in c#
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
}class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Dog(); // Upcasting: Dog object is treated as Animal
        myAnimal.Sound(); // Call the method from the base class
        
        // The following lines would cause a compile-time error because the methods are not defined in the base class
        // myAnimal.Bark(); 
        // myAnimal.Meow(); 

        Console.WriteLine("This is how to show the shield class in C#");
    }
}


