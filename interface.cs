//making two interfaces named, ram and shyam, and then creating a class named person that implements both interfaces. 

using System;
interface Ram
{
    void RamDetails();
}
interface Shyam
{
    void ShyamDetails();
}
class Person : Ram, Shyam
{
    public void RamDetails()
    {
        Console.WriteLine("This is Ram from Ram interface");
    }
    public void ShyamDetails()
    {
        Console.WriteLine("This is Shyam from Shyam interface");
    }
}
class Program
{
    static void Main()
    {
        Person p = new Person();
        p.RamDetails();
        p.ShyamDetails();
        Console.WriteLine("This is how to show the multiple inheritance using an Interface in C#");
    }
}