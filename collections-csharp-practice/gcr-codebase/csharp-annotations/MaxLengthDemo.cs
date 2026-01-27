using System;

[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute
{
    public int Value;
    public MaxLengthAttribute(int v) { Value = v; }
}

class User
{
    [MaxLength(5)]
    public string Username;

    public User(string name)
    {
        if (name.Length > 5)
            throw new ArgumentException("Username too long");

        Username = name;
    }
}

class MaxLengthDemo
{
    static void Test()
    {
        User u = new User("Admin");
        Console.WriteLine(u.Username);
    }

    public static void Main()
    {
        Test();
    }
}
