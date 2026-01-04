using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_obejct_oriented_design.object_modeling
{
    class Course
    {
        public string Name;
        public Student[] Students = new Student[5];
        public int count = 0;
    }

    // ---------------- Student ----------------
    class Student
    {
        public string Name;
        public Course[] Courses = new Course[5];
        public int count = 0;

        public void Enroll(Course course)
        {
            Courses[count++] = course;
            course.Students[course.count++] = this;
        }
    }

    // ---------------- School ----------------
    class School
    {
        public string Name;
        public Student[] Students = new Student[5];
    }

    // ---------------- Utility ----------------
    class SchoolUtility
    {
        public static void Main()
        {
            Student s1 = new Student { Name = "Amit" };
            Course c1 = new Course { Name = "Maths" };

            s1.Enroll(c1);

            Console.WriteLine($"{s1.Name} enrolled in {c1.Name}");
        }
    }
}
