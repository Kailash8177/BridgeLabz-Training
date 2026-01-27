using System;
using System.Text.RegularExpressions;

class LinkExtractor
{
    static void ExtractLinks(string text)
    {
        var matches = Regex.Matches(text, @"https?:\/\/[^\s]+");

        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }

    static void Main()
    {
        string text = "Visit https://google.com and http://example.org";
        ExtractLinks(text);
    }
}
