using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_2
{
    public class LeapYearCheck
    {
        public static void Main()
        {
            int year;
            bool isLeap;

            year = int.Parse(Console.ReadLine());

            if (year < 1582)
            {
                Console.WriteLine("Year is before 1582, cannot check Leap Year.");
                return;
            }

            isLeap = CheckLeapYear(year);

            if (isLeap)
            {
                Console.WriteLine("Year " + year + " is a Leap Year");
            }
            else
            {
                Console.WriteLine("Year " + year + " is not a Leap Year");
            }
        }

        public static bool CheckLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
