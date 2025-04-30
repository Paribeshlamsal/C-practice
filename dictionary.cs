using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a dictionary with string keys and int values
        Dictionary<string, int> ages = new Dictionary<string, int>();

        // Add key-value pairs to the dictionary
        ages["Alice"] = 25;
        ages["Bob"] = 30;
        ages["Charlie"] = 35;

        // Access a value by its key
        Console.WriteLine($"Alice's age: {ages["Alice"]}");

        // Check if a key exists
        if (ages.ContainsKey("David"))
        {
            Console.WriteLine("David is in the dictionary.");
        }
        else
        {
            Console.WriteLine("David is not in the dictionary.");
        }

        // Iterate through the dictionary
        foreach (var pair in ages)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        // Remove a key-value pair
        ages.Remove("Bob");

        // Check the count of items in the dictionary
        Console.WriteLine($"Total entries: {ages.Count}");
    }
}