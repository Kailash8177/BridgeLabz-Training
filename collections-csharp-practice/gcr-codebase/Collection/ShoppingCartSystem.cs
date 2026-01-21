using System;
using System.Collections.Generic;

class ShoppingCart
{
    static Dictionary<string, double> cart = new Dictionary<string, double>();
    static List<string> order = new List<string>();

    static void Main()
    {
        AddItem("Laptop", 50000);
        AddItem("Mouse", 500);
        AddItem("Keyboard", 1500);

        Console.WriteLine("Items sorted by price:");
        SortedDictionary<double, string> sorted =
            new SortedDictionary<double, string>();

        foreach (var item in cart)
            sorted[item.Value] = item.Key;

        foreach (var s in sorted)
            Console.WriteLine(s.Value + " : " + s.Key);
    }

    static void AddItem(string name, double price)
    {
        cart[name] = price;
        order.Add(name);
    }
}
