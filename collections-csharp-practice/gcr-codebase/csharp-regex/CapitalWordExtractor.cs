using System;
using System.Text.RegularExpressions;

class CapitalWordExtractor
{
    static void ExtractWords(string text)
    {
        var matches = Regex.Matches(text, @"\b[A-Z][a-z]*\b");

        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }

    static void Main()
    {
        string text = "The Eiffel Tower is in Paris and New York";
        ExtractWords(text);
    }
}
