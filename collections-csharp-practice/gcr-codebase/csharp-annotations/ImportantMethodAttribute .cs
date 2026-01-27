using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
    public string Level = "HIGH";
    public ImportantMethodAttribute() { }
    public ImportantMethodAttribute(string level) { Level = level; }
}

class Service
{
    [ImportantMethod]
    public void Save() { }

    [ImportantMethod("LOW")]
    public void Load() { }
}

class ImportantMethodDemo
{
    static void ShowImportant()
    {
        foreach (var m in typeof(Service).GetMethods())
        {
            var attr = Attribute.GetCustomAttribute(m, typeof(ImportantMethodAttribute))
                        as ImportantMethodAttribute;
            if (attr != null)
                Console.WriteLine(m.Name + " " + attr.Level);
        }
    }

    public static void Main()
    {
        ShowImportant();
    }
}
