using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class JsonFieldAttribute : Attribute
{
    public string Name;
}

class UserData
{
    [JsonField(Name = "user_name")]
    public string Name = "Kailash";

    [JsonField(Name = "user_id")]
    public int Id = 101;
}

class JsonDemo
{
    static void ToJson()
    {
        UserData u = new UserData();
        string json = "{";

        foreach (var f in typeof(UserData).GetFields())
        {
            var attr = (JsonFieldAttribute)
                Attribute.GetCustomAttribute(f, typeof(JsonFieldAttribute));
            json += $"\"{attr.Name}\":\"{f.GetValue(u)}\",";
        }

        Console.WriteLine(json.TrimEnd(',') + "}");
    }

    public static void Main()
    {
        ToJson();
    }
}

