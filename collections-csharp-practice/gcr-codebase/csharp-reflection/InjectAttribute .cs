using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
internal class InjectAttribute : Attribute { }

internal class Service
{
    public void Work()
    {
        Console.WriteLine("Service Working");
    }
}

internal class Client
{
    [Inject]
    public Service service;
}

internal class DIDemo
{
    static void Inject(object obj)
    {
        foreach (var f in obj.GetType().GetFields())
        {
            if (Attribute.IsDefined(f, typeof(InjectAttribute)))
            {
                object dep = Activator.CreateInstance(f.FieldType);
                f.SetValue(obj, dep);
            }
        }
    }

    public static void Main()
    {
        Client c = new Client();
        Inject(c);
        c.service.Work();
    }
}
