using System;
using System.Collections.Generic;

[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute { }

class Calculator
{
    static Dictionary<int, int> cache = new Dictionary<int, int>();

    [CacheResult]
    public int Square(int x)
    {
        if (cache.ContainsKey(x))
            return cache[x];

        Console.WriteLine("Calculating...");
        int result = x * x;
        cache[x] = result;
        return result;
    }
}

class CacheDemo
{
    static void Test()
    {
        Calculator c = new Calculator();
        Console.WriteLine(c.Square(5));
        Console.WriteLine(c.Square(5));
    }

    public static void Main()
    {
        Test();
    }
}
