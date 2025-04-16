using System;

class SampleCollection<T>
{
    private T[] items = new T[10];

    public T this[int index]
    {
        get => items[index];
        set => items[index] = value;
    }
}

class Program
{
    static void Main()
    {
        var collection = new SampleCollection<string>();
        collection[0] = "Hello";
        collection[1] = "World";

        Console.WriteLine(collection[0]); // Output: Hello
        Console.WriteLine(collection[1]); // Output: World
    }
}