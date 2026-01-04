using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_obejct_oriented_design.object_modeling
{
    // ---------------- Course ----------------
    class Course
    {
        public string Name;
    }

    // ---------------- Student ----------------
    class Student
    {
        public string Name;

        public void EnrollCourse(Course course)
        {
            Console.WriteLine($"{Name} enrolled in {course.Name}");
        }
    }

    // ---------------- Professor ----------------
    class Professor
    {
        public string Name;

        public void AssignProfessor(Course course)
        {
            Console.WriteLine($"{Name} teaches {course.Name}");
        }
    }

    // ---------------- Utility ----------------
    class UniversityManagementUtility
    {
        public static void Main()
        {
            Course c = new Course { Name = "OOPs" };
            Student s = new Student { Name = "Amit" };
            Professor p = new Professor { Name = "Dr. Singh" };

            s.EnrollCourse(c);
            p.AssignProfessor(c);
        }
    }

}
