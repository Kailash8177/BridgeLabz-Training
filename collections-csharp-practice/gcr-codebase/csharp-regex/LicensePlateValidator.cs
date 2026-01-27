using System;
using System.Text.RegularExpressions;

class LicensePlateValidator
{
    static bool IsValidPlate(string plate)
    {
        return Regex.IsMatch(plate, @"^[A-Z]{2}\d{4}$");
    }

    static void Main()
    {
        string[] plates = { "AB1234", "A12345", "XY9999" };

        foreach (string p in plates)
            Console.WriteLine($"{p} → {(IsValidPlate(p) ? "Valid" : "Invalid")}");
    }
}
