//create a class called employee that inherits from person and add a method employee_details.
// then create a another class called manager that inherits from employee and add a method department.

using System;

class Person
{
    public string name;
    public int age;
}

class Employee : Person
{
    public void employee_details()
    {
        Console.WriteLine("This is an employee.");
    }
}

class Manager : Employee
{
    public void department()
    {
        Console.WriteLine("Manager of Sales Department.");
    }
}

class Program
{
    static void Main()
    {
        Manager m = new Manager();
        m.name = "John";
        m.age = 30;

        Console.WriteLine("Name: " + m.name);
        Console.WriteLine("Age: " + m.age);
        m.employee_details();
        m.department();
    }
}