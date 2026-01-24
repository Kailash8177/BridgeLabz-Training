using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Stream
{
    internal class EmployeeSerialization
    {
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public double Salary { get; set; }
        }

        static void Main()
        {
            string filePath = "employees.json";

            List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Amit", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Neha", Department = "HR", Salary = 45000 }
        };

            string json = JsonSerializer.Serialize(employees);
            File.WriteAllText(filePath, json);

            string readJson = File.ReadAllText(filePath);
            List<Employee> loadedEmployees = JsonSerializer.Deserialize<List<Employee>>(readJson);

            foreach (var emp in loadedEmployees)
            {
                Console.WriteLine($"{emp.Id} {emp.Name} {emp.Department} {emp.Salary}");
            }
        }
    }
}
