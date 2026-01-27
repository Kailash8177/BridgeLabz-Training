using System;
using System.Collections;

class WarningSuppressDemo
{
    static void UseArrayList()
    {
#pragma warning disable
        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add("Hello");
#pragma warning restore

        foreach (var item in list)
            Console.WriteLine(item);
    }

    public static void Main()
    {
        UseArrayList();
    }
}
