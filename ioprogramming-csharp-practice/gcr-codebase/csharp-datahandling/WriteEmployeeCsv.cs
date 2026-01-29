using System;
using System.IO;

internal class WriteEmployeeCsv
{
    public static void Main(string[] args)
    {
        string filePath = "employees.csv";

        string[] records =
        {
            "ID,Name,Department,Salary",
            "1,Rahul,IT,50000",
            "2,Aman,HR,40000",
            "3,Priya,IT,60000",
            "4,Sneha,Finance,55000",
            "5,Rohit,Sales,45000"
        };

        File.WriteAllLines(filePath, records);
        Console.WriteLine("Employee CSV file created successfully.");
    }
}
