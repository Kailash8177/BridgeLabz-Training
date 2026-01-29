using System;
using System.IO;

internal class SearchEmployee
{
    public static void Main(string[] args)
    {
        string searchName = "Rahul";
        string[] lines = File.ReadAllLines("employees.csv");

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            if (data[1].Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Department: {data[2]}, Salary: {data[3]}");
                return;
            }
        }

        Console.WriteLine("Employee not found.");
    }
}
