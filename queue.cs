using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // STRING QUEUE
        Queue<string> q1 = new Queue<string>();
        q1.Enqueue("Amit");
        q1.Enqueue("Vijay");
        q1.Enqueue("Kumar");
        q1.Enqueue("Ravi");
        q1.Enqueue("Ajay");

        Console.WriteLine("String Queue elements:");
        foreach (string str in q1)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("Dequeue element is: " + q1.Dequeue());

        Console.WriteLine("String Queue after Dequeue:");
        foreach (string str in q1)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("Peek element is: " + q1.Peek());
        Console.WriteLine("String Queue after Peek:");
        foreach (string str in q1)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("\n-----------------------------\n");

        // INTEGER QUEUE
        Queue<int> q2 = new Queue<int>();
        q2.Enqueue(1);
        q2.Enqueue(2);
        q2.Enqueue(3);
        q2.Enqueue(4);

        Console.WriteLine("Integer Queue elements:");
        foreach (int i in q2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Dequeue element is: " + q2.Dequeue());

        Console.WriteLine("Integer Queue after Dequeue:");
        foreach (int i in q2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Peek element is: " + q2.Peek());
    }
}
