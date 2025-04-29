using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Add an element to the list
        numbers.Add(6);

        // Remove an element from the list
        numbers.Remove(3);

        // Iterate through the list and print each element
        Console.WriteLine("List elements:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // Create a dictionary with string keys and int values
        Dictionary<string, int> ages = new Dictionary<string, int>
        {
            { "Alice", 25 },
            { "Bob", 30 },
            { "Charlie", 35 }
        };

        // Add a new key-value pair
        ages["Diana"] = 28;

        // Access a value by its key
        Console.WriteLine("\nDiana's age: " + ages["Diana"]);

        // Iterate through the dictionary and print each key-value pair
        Console.WriteLine("\nDictionary elements:");
        foreach (KeyValuePair<string, int> entry in ages)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}