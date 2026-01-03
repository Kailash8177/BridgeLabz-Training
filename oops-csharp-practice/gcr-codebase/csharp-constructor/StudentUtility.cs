using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_constructor.level_1
{
    public class StudentUtility
    {
        public static void Main()
        {
            Student s = new Student(101, "Aman", 8.5);
            s.DisplayBasicInfo();
            Console.WriteLine("CGPA: " + s.GetCGPA());
        }
    }
    public class Student
    {
        public int RollNumber;        // public
        protected string Name;        // protected (not accessed outside)
        private double CGPA;          // private

        public Student(int roll, string name, double cgpa)
        {
            RollNumber = roll;
            Name = name;
            CGPA = cgpa;
        }

        // Public setter
        public void SetCGPA(double cgpa)
        {
            CGPA = cgpa;
        }

        // Public getter
        public double GetCGPA()
        {
            return CGPA;
        }

        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Roll: {RollNumber}, Name: {Name}");
        }
    }
}
