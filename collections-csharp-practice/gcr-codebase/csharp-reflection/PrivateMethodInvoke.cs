using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class PrivateMethodInvoke
{
    static void InvokeMethod()
    {
        Calculator c = new Calculator();
        Type t = typeof(Calculator);

        MethodInfo m = t.GetMethod("Multiply",BindingFlags.NonPublic | BindingFlags.Instance);

        object result = m.Invoke(c, new object[] { 5, 6 });
        Console.WriteLine("Result = " + result);
    }

    public static void Main()
    {
        InvokeMethod();
    }
}
