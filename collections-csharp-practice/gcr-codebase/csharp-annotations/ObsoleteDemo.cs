using System;

class LegacyAPI
{
    [Obsolete("Use NewFeature instead")]
    public void OldFeature()
    {
        Console.WriteLine("Old Feature");
    }

    public void NewFeature()
    {
        Console.WriteLine("New Feature");
    }
}

class ObsoleteDemo
{
    static void TestAPI()
    {
        LegacyAPI api = new LegacyAPI();
        api.OldFeature();   // Warning
        api.NewFeature();
    }

    public static void Main()
    {
        TestAPI();
    }
}
