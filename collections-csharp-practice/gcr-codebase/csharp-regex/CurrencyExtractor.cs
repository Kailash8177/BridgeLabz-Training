using System;
using System.Text.RegularExpressions;

class CurrencyExtractor
{
    static void ExtractCurrency(string text)
    {
        var matches = Regex.Matches(text, @"\$?\s?\d+\.\d{2}");

        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }

    static void Main()
    {
        string text = "Price $45.99 and discount $ 10.50";
        ExtractCurrency(text);
    }
}
