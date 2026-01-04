using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_obejct_oriented_design.object_modeling
{
    // ---------------- Faculty ----------------
    class Faculty
    {
        public string Name;
    }

    // ---------------- Department ----------------
    class Department
    {
        public string Name;
    }

    // ---------------- University ----------------
    class University
    {
        public Department[] Departments = new Department[3]; // Composition
        public Faculty[] Faculties = new Faculty[3];         // Aggregation
    }

    // ---------------- Utility ----------------
    class UniversityUtility
    {
        public static void Main()
        {
            Faculty f1 = new Faculty { Name = "Dr. Sharma" };

            University uni = new University();
            uni.Faculties[0] = f1;
            uni.Departments[0] = new Department { Name = "CSE" };

            uni = null;
            Console.WriteLine("University deleted");
        }
    }
}
