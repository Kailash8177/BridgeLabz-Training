using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_inheritance
{
    // ---------------- Base Class ----------------
    class Course
    {
        public string CourseName;
        public int Duration; // in hours
    }

    // ---------------- Child Class ----------------
    class OnlineCourse : Course
    {
        public string Platform;
        public bool IsRecorded;
    }

    // ---------------- Final Child Class ----------------
    class PaidOnlineCourse : OnlineCourse
    {
        public double Fee;
        public double Discount;
    }

    // ---------------- Utility Class ----------------
    class CourseUtility
    {
        public static void Main()
        {
            PaidOnlineCourse course = new PaidOnlineCourse
            {
                CourseName = "C# OOPs",
                Duration = 40,
                Platform = "Udemy",
                IsRecorded = true,
                Fee = 5000,
                Discount = 10
            };

            Console.WriteLine($"Course: {course.CourseName}, Fee: {course.Fee}");
        }
    }
}
