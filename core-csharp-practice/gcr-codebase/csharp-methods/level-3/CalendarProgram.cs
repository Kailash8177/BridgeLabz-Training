using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_3
{
    public class CalendarProgram
    {
        public static void Main()
        {
            Console.WriteLine("Enter month (1-12) and year:");
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            DisplayCalendar(month, year);
        }

        public static void DisplayCalendar(int month, int year)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int days = GetDaysInMonth(month, year);

            Console.WriteLine("     " + months[month - 1] + " " + year);
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            int firstDay = GetFirstDayOfMonth(month, year);

            for (int i = 0; i < firstDay; i++) Console.Write("    ");
            for (int day = 1; day <= days; day++)
            {
                Console.Write("{0,3} ", day);
                if ((firstDay + day) % 7 == 0) Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int GetDaysInMonth(int month, int year)
        {
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (month == 2 && IsLeapYear(year)) return 29;
            return daysInMonth[month - 1];
        }

        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        public static int GetFirstDayOfMonth(int month, int year)
        {
            int y = year - (14 - month) / 12;
            int x = y + y / 4 - y / 100 + y / 400;
            int m = month + 12 * ((14 - month) / 12) - 2;
            int d = (1 + x + 31 * m / 12) % 7;
            return d;
        }
    }
}
