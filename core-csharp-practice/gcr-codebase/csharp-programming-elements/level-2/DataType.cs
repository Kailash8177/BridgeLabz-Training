using System;

public class DataTypes
{
    public static void Main()
    {
        // Value Data Types
        int a = 10;
        float b = 10.5f;
        double c = 99.99;
        char d = 'A';
        bool e = true;

        Console.WriteLine("Integer: " + a);
        Console.WriteLine("Float: " + b);
        Console.WriteLine("Double: " + c);
        Console.WriteLine("Character: " + d);
        Console.WriteLine("Boolean: " + e);

        // String (Reference Type)
        string name = "Kailash";
        Console.WriteLine("String: " + name);

       
       // Type Casting
        double num = 49.77;
        int castNum = (int)num;

        Console.WriteLine("Double value: " + num);
        Console.WriteLine("After Casting to int: " + castNum);

        // is Operator with Data Types
        object obj1 = 57;
        object obj2 = "Hello";
        Console.WriteLine("obj1 is int: " + (obj1 is int));
        Console.WriteLine("obj2 is string: " + (obj2 is string));
    }
}