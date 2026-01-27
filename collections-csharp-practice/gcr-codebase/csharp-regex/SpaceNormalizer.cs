using System;
using System.Text.RegularExpressions;

class SpaceNormalizer
{
    static string Normalize(string text)
    {
        return Regex.Replace(text, @"\s+", " ");
    }

    static void Main()
    {
        string text = "This   is    an   example";
        Console.WriteLine(Normalize(text));
    }
}
