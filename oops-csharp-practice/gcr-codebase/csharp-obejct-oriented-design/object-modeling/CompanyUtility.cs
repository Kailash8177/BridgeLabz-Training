using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_obejct_oriented_design.object_modeling
{
    class Employee
    {
        public string Name;

        public Employee(string name)
        {
            Name = name;
        }
    }

    // ---------------- Department ----------------
    class Department
    {
        public string DeptName;
        public Employee[] Employees = new Employee[3];
        public int empCount = 0;

        public Department(string name)
        {
            DeptName = name;
        }

        public void AddEmployee(Employee e)
        {
            Employees[empCount++] = e;
        }
    }

    // ---------------- Company ----------------
    class Company
    {
        public string Name;
        public Department[] Departments = new Department[2];
        public int deptCount = 0;

        public Company(string name)
        {
            Name = name;
        }

        public void AddDepartment(Department d)
        {
            Departments[deptCount++] = d;
        }
    }

    // ---------------- Utility ----------------
    class CompanyUtility
    {
        public static void Main()
        {
            Company comp = new Company("TechCorp");

            Department d1 = new Department("IT");
            d1.AddEmployee(new Employee("Rahul"));

            comp.AddDepartment(d1);

            comp = null; // Composition: everything removed
            Console.WriteLine("Company deleted");
        }
    }

}
