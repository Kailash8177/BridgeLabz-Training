using System;
using System.Reflection;

internal class Sample
{
    public int x;
    private string y;

    public Sample() { }
    private Sample(int a) { }

    public void Show() { }
    private void Hidden() { }
}

internal class ClassInfo
{
    public static void Main()
    {
        Type t = typeof(Sample);

        Console.WriteLine("Methods:");
        foreach (var m in t.GetMethods(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            Console.WriteLine(m.Name);

        Console.WriteLine("\nFields:");
        foreach (var f in t.GetFields(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            Console.WriteLine(f.Name);

        Console.WriteLine("\nConstructors:");
        foreach (var c in t.GetConstructors(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            Console.WriteLine(c);
    }
}
