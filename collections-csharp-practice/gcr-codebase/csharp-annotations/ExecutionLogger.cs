using System;
using System.Diagnostics;

[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute { }

class Processor
{
    [LogExecutionTime]
    public void Work()
    {
        for (int i = 0; i < 1000000; i++) ;
    }
}

class ExecutionLogger
{
    static void Execute()
    {
        Processor p = new Processor();
        Stopwatch sw = Stopwatch.StartNew();
        p.Work();
        sw.Stop();

        Console.WriteLine("Time: " + sw.ElapsedMilliseconds + " ms");
    }

    public static void Main()
    {
        Execute();
    }
}
