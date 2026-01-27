using System;

[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
    public string Role;
    public RoleAllowedAttribute(string role) { Role = role; }
}

class AdminPanel
{
    [RoleAllowed("ADMIN")]
    public void DeleteUser()
    {
        Console.WriteLine("User Deleted");
    }
}

class RoleDemo
{
    static void Access(string role)
    {
        var m = typeof(AdminPanel).GetMethod("DeleteUser");
        var attr = (RoleAllowedAttribute)
            Attribute.GetCustomAttribute(m, typeof(RoleAllowedAttribute));

        if (attr.Role == role)
            m.Invoke(new AdminPanel(), null);
        else
            Console.WriteLine("Access Denied!");
    }

    public static void Main()
    {
        Access("USER");
    }
}
