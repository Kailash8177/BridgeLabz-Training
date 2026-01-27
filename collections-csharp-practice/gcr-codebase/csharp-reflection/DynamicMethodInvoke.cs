using System;
using System.Reflection;

internal class MathOperations
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
}

internal class DynamicMethodInvoke
{
    public static void Main()
    {
        MathOperations obj = new MathOperations();
        Type t = typeof(MathOperations);

        string methodName = "Multiply";
        MethodInfo m = t.GetMethod(methodName);

        object result = m.Invoke(obj, new object[] { 4, 5 });
        Console.WriteLine(result);
    }
}
