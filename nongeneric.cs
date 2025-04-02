using System;
using System.Collections;

class Program
{
    static void Main(){
        Hashtable students = new Hashtable();
        students.Add(101,"Sabin");
        students.Add(102,"Sanjay");
        students.Add(103,"Arun");
        
    foreach (DictionaryEntry entry in students)
    {
        Console.WriteLine("Key:"+entry.Key+"Value:"+entry.Value);
    }
    }
}