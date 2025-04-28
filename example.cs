//example of getting the type name of an object
using System;
class Program
{
    static void Main()
    {
        int number = 42;
        string typeName = number.GetType().Name;
        Console.WriteLine($"The type of the variable is: {typeName}");
    }
}