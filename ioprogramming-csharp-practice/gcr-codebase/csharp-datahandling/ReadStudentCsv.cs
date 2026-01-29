using System;
using System.IO;

internal class ReadStudentCsv
{
    public static void Main(string[] args)
    {
        string filePath = "students.csv";
        string[] lines = File.ReadAllLines(filePath);

        for (int i = 1; i < lines.Length; i++) // Skip header
        {
            string[] data = lines[i].Split(',');

            Console.WriteLine(
                $"ID: {data[0]}, Name: {data[1]}, Age: {data[2]}, Marks: {data[3]}"
            );
        }
    }
}
