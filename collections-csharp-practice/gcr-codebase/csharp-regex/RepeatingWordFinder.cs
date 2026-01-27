using System;
using System.Text.RegularExpressions;

class RepeatingWordFinder
{
    static void FindRepeats(string text)
    {
        var matches = Regex.Matches(text, @"\b(\w+)\s+\1\b");

        foreach (Match m in matches)
            Console.WriteLine(m.Groups[1].Value);
    }

    static void Main()
    {
        string text = "This is is a repeated repeated test";
        FindRepeats(text);
    }
}
