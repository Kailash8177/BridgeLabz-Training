using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_constructor.level_1
{
    public class CourseUtility
    {
        public static void Main()
        {
            Course.UpdateInstituteName("GLA University");

            Course c1 = new Course("C#", 6, 30000);
            Course c2 = new Course("Java", 5, 28000);

            c1.DisplayCourseDetails();
            c2.DisplayCourseDetails();
        }
    }
    public class Course
    {
        // Instance variables
        public string CourseName;
        public int Duration;
        public double Fee;

        // Class variable
        public static string InstituteName = "Default Institute";

        public Course(string courseName, int duration, double fee)
        {
            CourseName = courseName;
            Duration = duration;
            Fee = fee;
        }

        // Instance method
        public void DisplayCourseDetails()
        {
            Console.WriteLine($"{CourseName} | {Duration} months | {Fee} | {InstituteName}");
        }

        // Class method
        public static void UpdateInstituteName(string newName)
        {
            InstituteName = newName;
        }
    }
}
