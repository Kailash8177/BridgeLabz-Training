using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
internal class AuthorAttribute : Attribute
{
    public string Name;
    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

[Author("Kailash")]
internal class Book { }

internal class AttributeDemo
{
    public static void Main()
    {
        Type t = typeof(Book);
        AuthorAttribute attr =
            (AuthorAttribute)Attribute.GetCustomAttribute(t, typeof(AuthorAttribute));

        Console.WriteLine("Author = " + attr.Name);
    }
}
