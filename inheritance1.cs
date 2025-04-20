//create two different classes named rose and lily and specific method relevant to that type of class, then make a class named flower that inherits from both rose and lily. show how to achieve.

using System;

// Rose interface
interface Rose
{
    void RoseDetails();
}
interface Lily
{
    void LilyDetails();
}
class flower : Rose, Lily{
    public void RoseDetails()
    {
        Console.WriteLine("This is rose");
    }
    public void LilyDetails()
    {
        Console.WriteLine("This is lily");
    }
}
class Program
{
    static void Main()
    {
        flower f= new flower();
        f.RoseDetails();
        f.LilyDetails();
        f.RoseDetails();
        f.LilyDetails();
        f.RoseDetails();


        f.RoseDetails();
        f.LilyDetails();
        f.RoseDetails();
        f.LilyDetails();
        f.RoseDetails();
        f.LilyDetails();
        f.RoseDetails();
        f.LilyDetails();
        f.RoseDetails();
        f.LilyDetails();

        f.RoseDetails();
        f.LilyDetails();
        f.RoseDetails();
        f.LilyDetails();
        f.RoseDetails();
        f.LilyDetails();
        f.RoseDetails();
        f.LilyDetails();
        f.RoseDetails();
        Console.WriteLine("This is how to show the multiple inheritance using an Interface in C#");

    }
}