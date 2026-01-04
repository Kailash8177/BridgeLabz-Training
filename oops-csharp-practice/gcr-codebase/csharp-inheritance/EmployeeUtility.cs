using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_inheritance
{

    // ---------------- Base Class ----------------
    class Employee
    {
        public string Name;
        public int Id;
        public double Salary;
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Id: {Id}, Salary: {Salary}");
        }
    }

    // ---------------- Manager Class ----------------
    class Manager : Employee
    {
        public int TeamSize;

        public override void DisplayDetails()
        {
            Console.WriteLine(
                $"Name: {Name}, Id: {Id}, Salary: {Salary}, Team Size: {TeamSize}"
            );
        }
    }

    // ---------------- Developer Class ----------------
    class Developer : Employee
    {
        public string ProgrammingLanguage;

        public override void DisplayDetails()
        {
            Console.WriteLine(
                $"Name: {Name}, Id: {Id}, Salary: {Salary}, Language: {ProgrammingLanguage}"
            );
        }
    }

    // ---------------- Intern Class ----------------
    class Intern : Employee
    {
        public string InternshipDuration;

        public override void DisplayDetails()
        {
            Console.WriteLine(
                $"Name: {Name}, Id: {Id}, Salary: {Salary}, Duration: {InternshipDuration}"
            );
        }
    }

    // ---------------- Main Class ----------------
    class EmployeeUtility
    {
        public static void Main()
        {
            // Creating different employee objects
            Employee emp1 = new Manager
            {
                Name = "Rahul",
                Id = 101,
                Salary = 80000,
                TeamSize = 8
            };

            Employee emp2 = new Developer
            {
                Name = "Amit",
                Id = 102,
                Salary = 60000,
                ProgrammingLanguage = "C#"
            };

            Employee emp3 = new Intern
            {
                Name = "Neha",
                Id = 103,
                Salary = 15000,
                InternshipDuration = "6 Months"
            };

            // Polymorphic calls
            emp1.DisplayDetails();
            emp2.DisplayDetails();
            emp3.DisplayDetails();
        }
    }
}
