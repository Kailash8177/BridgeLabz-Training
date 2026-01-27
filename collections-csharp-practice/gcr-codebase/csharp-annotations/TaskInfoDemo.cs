using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfoAttribute : Attribute
{
    public string Priority;
    public string AssignedTo;

    public TaskInfoAttribute(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    [TaskInfo("HIGH", "Kailash")]
    public void CompleteTask() { }
}

class TaskInfoDemo
{
    static void ReadAttribute()
    {
        MethodInfo m = typeof(TaskManager).GetMethod("CompleteTask");
        TaskInfoAttribute attr =
            (TaskInfoAttribute)Attribute.GetCustomAttribute(m, typeof(TaskInfoAttribute));

        Console.WriteLine(attr.Priority + " " + attr.AssignedTo);
    }

    public static void Main()
    {
        ReadAttribute();
    }
}
