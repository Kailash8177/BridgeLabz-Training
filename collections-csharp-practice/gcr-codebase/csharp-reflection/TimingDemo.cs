using System;
using System.Diagnostics;
using System.Reflection;

internal class TaskClass
{
    public void Work()
    {
        for (int i = 0; i < 1000000; i++) ;
    }
}

internal class TimingDemo
{
    public static void Main()
    {
        TaskClass obj = new TaskClass();
        MethodInfo m = typeof(TaskClass).GetMethod("Work");

        Stopwatch sw = Stopwatch.StartNew();
        m.Invoke(obj, null);
        sw.Stop();

        Console.WriteLine("Execution Time = " + sw.ElapsedMilliseconds + " ms");
    }
}
