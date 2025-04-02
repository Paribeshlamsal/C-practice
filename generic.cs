using System;
using System.Collections.Generic; 

class Program
{
    static void Main()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(101, "Sabin");
        students.Add(102, "Sanjay");
        students.Add(103, "Arun");

        foreach (KeyValuePair<int, string> entry in students)
        {
            Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }
    }
}
