using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_class_object.level_1
{
    public class EmployeeDetails
    {
        public string name;
        public int id;
        public double salary;
        public void DisplayDetails()
        {
            Console.WriteLine("Employee Name   : " + name);
            Console.WriteLine("Employee ID     : " + id);
            Console.WriteLine("Employee Salary : " + salary);
        }
    }
    public class Employee
    {
        static void Main(string[] args)
        {
            EmployeeDetails emp = new EmployeeDetails();

            Console.WriteLine("Enter Employee Name:");
            emp.name = Console.ReadLine();

            Console.WriteLine("Enter Employee ID:");
            emp.id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Salary:");
            emp.salary = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEmployee Details:");
            emp.DisplayDetails();
        }
    }
}
