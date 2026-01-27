using System;
using System.Text.RegularExpressions;

class IPValidator
{
    static bool IsValidIP(string ip)
    {
        string pattern =
        @"^((25[0-5]|2[0-4]\d|[01]?\d\d?)\.){3}" +
        @"(25[0-5]|2[0-4]\d|[01]?\d\d?)$";

        return Regex.IsMatch(ip, pattern);
    }

    static void Main()
    {
        string[] ips = { "192.168.1.1", "999.1.1.1" };

        foreach (string ip in ips)
            Console.WriteLine($"{ip} → {(IsValidIP(ip) ? "Valid" : "Invalid")}");
    }
}
