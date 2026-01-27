using System;
using System.Text.RegularExpressions;

class HexColorValidator
{
    static bool IsValidHex(string color)
    {
        return Regex.IsMatch(color, @"^#[0-9a-fA-F]{6}$");
    }

    static void Main()
    {
        string[] colors = { "#FFA500", "#ff4500", "#123" };

        foreach (string c in colors)
            Console.WriteLine($"{c} → {(IsValidHex(c) ? "Valid" : "Invalid")}");
    }
}
