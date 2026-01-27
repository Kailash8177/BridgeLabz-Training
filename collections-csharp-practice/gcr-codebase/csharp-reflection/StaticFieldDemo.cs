using System;
using System.Reflection;

internal class Configuration
{
    private static string API_KEY = "OLD_KEY";
}

internal class StaticFieldDemo
{
    public static void Main()
    {
        FieldInfo field = typeof(Configuration)
            .GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        field.SetValue(null, "NEW_KEY");
        Console.WriteLine(field.GetValue(null));
    }
}
