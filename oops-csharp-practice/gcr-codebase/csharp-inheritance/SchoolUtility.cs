using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_inheritance
{
    // ---------------- Base Class ----------------
    class Person
    {
        public string Name;
        public int Age;
    }

    // ---------------- Teacher ----------------
    class Teacher : Person
    {
        public string Subject;

        public void DisplayRole()
        {
            Console.WriteLine("Role: Teacher");
        }
    }

    // ---------------- Student ----------------
    class Student : Person
    {
        public string Grade;

        public void DisplayRole()
        {
            Console.WriteLine("Role: Student");
        }
    }

    // ---------------- Staff ----------------
    class Staff : Person
    {
        public string Department;

        public void DisplayRole()
        {
            Console.WriteLine("Role: Staff");
        }
    }

    // ---------------- Utility Class ----------------
    class SchoolUtility
    {
        public static void Main()
        {
            Teacher t = new Teacher();
            Student s = new Student();
            Staff st = new Staff();

            t.DisplayRole();
            s.DisplayRole();
            st.DisplayRole();
        }
    }
}
