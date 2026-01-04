using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_this_static_sealed_is
{
    public class EmployeeUtility
    {
        public static void Main()
        {
            object emp = new Employee("Ravi", 201, "Developer");

            if (emp is Employee)
            {
                ((Employee)emp).Display();
            }

            Employee.DisplayTotalEmployees();
        }

    }
    public class Employee
    {
        public static string CompanyName = "TechCorp";
        private static int totalEmployees = 0;

        public readonly int Id;
        public string Name;
        public string Designation;

        public Employee(string name, int id, string designation)
        {
            this.Name = name;
            this.Id = id;
            this.Designation = designation;
            totalEmployees++;
        }

        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("Total Employees: " + totalEmployees);
        }

        public void Display()
        {
            Console.WriteLine($"{CompanyName} | {Name} | {Id} | {Designation}");
        }
    }
}
