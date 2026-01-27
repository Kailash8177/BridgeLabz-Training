using System;
using System.Text.RegularExpressions;

class LanguageExtractor
{
    static void ExtractLanguages(string text)
    {
        var matches = Regex.Matches(text,
            @"\b(Java|Python|JavaScript|Go)\b");

        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }

    static void Main()
    {
        string text = "I love Java, Python, JavaScript and Go";
        ExtractLanguages(text);
    }
}
