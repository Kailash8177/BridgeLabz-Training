using System;
using System.Collections.Generic;
using System.Reflection;

internal class User
{
    public int Id;
    public string Name;
}

internal class ObjectMapper
{
    static T ToObject<T>(Dictionary<string, object> map) where T : new()
    {
        T obj = new T();
        Type t = typeof(T);

        foreach (var item in map)
        {
            FieldInfo f = t.GetField(item.Key);
            if (f != null)
                f.SetValue(obj, item.Value);
        }
        return obj;
    }

    public static void Main()
    {
        var data = new Dictionary<string, object>
        {
            {"Id",101},
            {"Name","Rahul"}
        };

        User u = ToObject<User>(data);
        Console.WriteLine(u.Id + " " + u.Name);
    }
}
