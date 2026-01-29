using System;
using System.IO;

internal class CountCsvRows
{
    public static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("students.csv");
        int recordCount = lines.Length - 1;

        Console.WriteLine("Total Records: " + recordCount);
    }
}
