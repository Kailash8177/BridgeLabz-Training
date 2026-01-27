using System;
using System.Text.RegularExpressions;

class EmailExtractor
{
    static void ExtractEmails(string text)
    {
        var matches = Regex.Matches(text,
            @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b");

        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }

    static void Main()
    {
        string text = "Contact support@example.com and info@company.org";
        ExtractEmails(text);
    }
}
