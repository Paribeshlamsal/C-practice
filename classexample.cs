// public class Vehicle{
//     string name, model;
//     int year;

//     void speed(){
//         Console.WriteLine("Hello Speed.")
//     }
//     void brake(){
//         Console.WriteLine("Hello brake.")


//     }
// }
using System;
public class Student{
    string name, gender;
    int age;

    void person(string name,string gender,int age){
        this.name = name;
        this.gender = gender;
        this.age = age
    }
    void display(){
        Console.WriteLine($"Name is {name}, Age is {age},Gender is {gender}")
    }
    public static void Main(){
        Student s = new Student();
        s.person("Shyam","Male",15);
        s.display()gigit
    }
}