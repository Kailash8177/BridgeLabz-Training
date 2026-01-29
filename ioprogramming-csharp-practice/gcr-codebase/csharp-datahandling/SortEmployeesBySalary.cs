using System;
using System.IO;
using System.Linq;

internal class SortEmployeesBySalary
{
    public static void Main(string[] args)
    {
        var employees = File.ReadAllLines("employees.csv")
                            .Skip(1)
                            .Select(line =>
                            {
                                string[] data = line.Split(',');
                                return new
                                {
                                    Name = data[1],
                                    Department = data[2],
                                    Salary = double.Parse(data[3])
                                };
                            })
                            .OrderByDescending(e => e.Salary)
                            .Take(5);

        Console.WriteLine("Top 5 Highest Paid Employees:");

        foreach (var emp in employees)
        {
            Console.WriteLine($"{emp.Name} | {emp.Department} | {emp.Salary}");
        }
    }
}
