using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TodoAttribute : Attribute
{
    public string Task;
    public string AssignedTo;
    public string Priority = "MEDIUM";

    public TodoAttribute(string task, string assignedTo)
    {
        Task = task;
        AssignedTo = assignedTo;
    }
}

class Project
{
    [Todo("Add login", "Amit")]
    public void Login() { }

    [Todo("Fix bug", "Rahul", Priority = "HIGH")]
    public void FixBug() { }
}

class TodoDemo
{
    static void ShowTodos()
    {
        foreach (var m in typeof(Project).GetMethods())
        {
            var t = Attribute.GetCustomAttribute(m, typeof(TodoAttribute)) as TodoAttribute;
            if (t != null)
                Console.WriteLine($"{t.Task} {t.AssignedTo} {t.Priority}");
        }
    }

    public static void Main()
    {
        ShowTodos();
    }
}
