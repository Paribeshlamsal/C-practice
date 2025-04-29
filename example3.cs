using System;
using System.Collections.Generic;
class Test<T>
{
    T[] items=new T[10];
    int count=0;
    public void AddItem(T item){
        if(count<5)
        {
            items[count]=item;
            count++;
        }
        else
        {
            Console.WriteLine("Array is full");
        }
    }
    public void display()
    {
        for(int i=0;i<count;i++)
        {
            Console.WriteLine(items[i]);
        }
    }
}
class Program
{
    static void Main()
    {
        Test<int>obj=new Test<int>();
        obj.AddItem(1);
        obj.AddItem(2);
        obj.AddItem(3);
        obj.AddItem(4);
        obj.AddItem(5);
        obj.AddItem(6); // This will not be added as the array is full
        obj.display();
    }
}