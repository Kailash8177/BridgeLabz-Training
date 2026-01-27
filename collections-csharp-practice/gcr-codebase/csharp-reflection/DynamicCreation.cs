using System;

class Student
{
    public string Name = "Ravi";
}

class DynamicCreation
{
    static void CreateObject()
    {
        Type t = typeof(Student);
        object obj = Activator.CreateInstance(t);

        Console.WriteLine(((Student)obj).Name);
    }

    public static void Main()
    {
        CreateObject();
    }
}
