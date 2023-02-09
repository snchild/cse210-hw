using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        MyClass object1 = new MyClass(); //instance

        MyClass object2 = new MyClass(); //NEW instance

        object1._name = "object 1's name"; //modifying an attribute for one instance
        object2._name = "object 2's name"; //modifying an attribute for a different instance

        object1.DisplayName(); //calling a method in the class
        object2.DisplayName(); 

    }
}