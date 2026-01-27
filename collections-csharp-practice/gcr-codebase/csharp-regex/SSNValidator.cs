using System;
using System.Text.RegularExpressions;

class SSNValidator
{
    static bool IsValidSSN(string ssn)
    {
        return Regex.IsMatch(ssn, @"^\d{3}-\d{2}-\d{4}$");
    }

    static void Main()
    {
        string[] ssns = { "123-45-6789", "123456789" };

        foreach (string s in ssns)
            Console.WriteLine($"{s} → {(IsValidSSN(s) ? "Valid" : "Invalid")}");
    }
}
