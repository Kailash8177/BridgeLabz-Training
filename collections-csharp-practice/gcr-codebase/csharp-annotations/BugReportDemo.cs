using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description;
    public BugReportAttribute(string desc) { Description = desc; }
}

class Software
{
    [BugReport("Null issue")]
    [BugReport("Performance issue")]
    public void Run() { }
}

class BugReportDemo
{
    static void ReadBugs()
    {
        MethodInfo m = typeof(Software).GetMethod("Run");
        var bugs = m.GetCustomAttributes(typeof(BugReportAttribute), false);

        foreach (BugReportAttribute b in bugs)
            Console.WriteLine(b.Description);
    }

    public static void Main()
    {
        ReadBugs();
    }
}
