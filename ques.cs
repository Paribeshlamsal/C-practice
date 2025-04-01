using System;
public class Nishma
{
    public static void Main(){
        Console.Write("Enter first number - ");
        double a = convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number - ");
        double b = convert.ToDouble(Console.ReadLine());
        double sum = a+b;
        double diff = a-b;
        double mul = a*b;
        double div = a/b;
        Console.WriteLine(sum);
        Console.WriteLine(diff);
        Console.WriteLine(mul);
        Console.WriteLine(div);
    }
}

