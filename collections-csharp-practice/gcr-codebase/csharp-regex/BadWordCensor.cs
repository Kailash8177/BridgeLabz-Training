using System;
using System.Text.RegularExpressions;

class BadWordCensor
{
    static string Censor(string text)
    {
        return Regex.Replace(text,
            @"\b(damn|stupid)\b",
            "****",
            RegexOptions.IgnoreCase);
    }

    static void Main()
    {
        string text = "This is a damn stupid example";
        Console.WriteLine(Censor(text));
    }
}
