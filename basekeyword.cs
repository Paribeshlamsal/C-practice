using System;

class Parent
{
    public virtual void Display()
    {
        Console.WriteLine("This is the Parent class.");
    }
}

class Child : Parent
{
    public override void Display()
    {
        base.Display(); // Call the method from the Parent class
        Console.WriteLine("This is the Child class.");
    }
}

class Program
{
    static void Main()
    {
        Child child = new Child();
        child.Display();
    }
}