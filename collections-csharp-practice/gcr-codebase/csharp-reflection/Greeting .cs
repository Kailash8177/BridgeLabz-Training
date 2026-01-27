using System;
using System.Reflection;

internal interface IGreeting
{
    void SayHello();
}

internal class Greeting : IGreeting
{
    public void SayHello()
    {
        Console.WriteLine("Hello World");
    }
}

internal class LoggingProxy : DispatchProxy
{
    private object target;

    protected override object Invoke(MethodInfo method, object[] args)
    {
        Console.WriteLine("Calling Method: " + method.Name);
        return method.Invoke(target, args);
    }

    public static T Create<T>(T obj)
    {
        T proxy = Create<T, LoggingProxy>();
        ((LoggingProxy)(object)proxy).target = obj;
        return proxy;
    }
}

internal class ProxyDemo
{
    public static void Main()
    {
        IGreeting g = LoggingProxy.Create<IGreeting>(new Greeting());
        g.SayHello();
    }
}
