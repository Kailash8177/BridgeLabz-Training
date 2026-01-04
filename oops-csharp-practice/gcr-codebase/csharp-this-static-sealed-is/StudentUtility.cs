using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_this_static_sealed_is
{
    public class StudentUtility
    {
        public static void Main()
        {
            object s = new Student("Karan", 301, "A");

            if (s is Student)
            {
                ((Student)s).Display();
            }

            Student.DisplayTotalStudents();
        }
    }
    public class Student
    {
        public static string UniversityName = "GLA University";
        private static int totalStudents = 0;

        public readonly int RollNumber;
        public string Name;
        public string Grade;

        public Student(string name, int rollNumber, string grade)
        {
            this.Name = name;
            this.RollNumber = rollNumber;
            this.Grade = grade;
            totalStudents++;
        }

        public static void DisplayTotalStudents()
        {
            Console.WriteLine("Total Students: " + totalStudents);
        }

        public void Display()
        {
            Console.WriteLine($"{UniversityName} | {Name} | {RollNumber} | {Grade}");
        }
    }

}
