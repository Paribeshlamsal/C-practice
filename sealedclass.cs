using System;

sealed class SealedClass
{
    public void DisplayMessage()
    {
        Console.WriteLine("This is a sealed class.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SealedClass obj = new SealedClass();
        obj.DisplayMessage();
    }
}
