using System;
using System.IO;
using System.Collections.Generic;

internal class UpdateItDepartmentSalary
{
    public static void Main(string[] args)
    {
        string inputFile = "employees.csv";
        string outputFile = "updated_employees.csv";

        string[] lines = File.ReadAllLines(inputFile);
        List<string> updatedRecords = new List<string>();

        updatedRecords.Add(lines[0]); // header

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            double salary = double.Parse(data[3]);

            if (data[2] == "IT")
            {
                salary = salary + (salary * 0.10);
            }

            updatedRecords.Add($"{data[0]},{data[1]},{data[2]},{salary}");
        }

        File.WriteAllLines(outputFile, updatedRecords);

        Console.WriteLine("IT department salaries updated successfully.");
    }
}
