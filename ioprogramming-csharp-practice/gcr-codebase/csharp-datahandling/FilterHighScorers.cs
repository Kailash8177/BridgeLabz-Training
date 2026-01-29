using System;
using System.IO;

internal class FilterHighScorers
{
    public static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("students.csv");

        Console.WriteLine("Students scoring above 80:");

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');
            int marks = int.Parse(data[3]);

            if (marks > 80)
            {
                Console.WriteLine($"{data[1]} - {marks}");
            }
        }
    }
}
