using System;
using System.Text.RegularExpressions;

class CreditCardValidator
{
    static string CardType(string card)
    {
        if (Regex.IsMatch(card, @"^4\d{15}$")) return "Visa";
        if (Regex.IsMatch(card, @"^5\d{15}$")) return "MasterCard";
        return "Invalid";
    }

    static void Main()
    {
        string[] cards = { "4123456789012345", "5123456789012345", "1234" };

        foreach (string c in cards)
            Console.WriteLine($"{c} → {CardType(c)}");
    }
}
