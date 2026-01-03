using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_constructor.level_1
{
    public class EmployeeUtility
    {
        public static void Main()
        {
            Employee e = new Employee(201, "IT", 60000);
            e.Display();
            e.UpdateSalary(70000);
            Console.WriteLine("Salary: " + e.GetSalary());
        }
    }
    public class Employee
    {
        public int EmployeeID;        // public
        protected string Department;  // protected
        private double Salary;        // private

        public Employee(int id, string dept, double salary)
        {
            EmployeeID = id;
            Department = dept;
            Salary = salary;
        }

        public void UpdateSalary(double salary)
        {
            Salary = salary;
        }

        public double GetSalary()
        {
            return Salary;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {EmployeeID}, Department: {Department}");
        }
    }
}
