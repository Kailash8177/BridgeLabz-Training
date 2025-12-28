using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_builtin.level_1
{
    public class DateArithmetic
    {
        public static void Main()
        {

            DateTime date = DateTime.Parse(Console.ReadLine());
            date = date.AddDays(7);
            date = date.AddMonths(1);
            date = date.AddYears(2);
            date = date.AddDays(-21); // 3 weeks = 21 days

            Console.WriteLine("Final Date: " + date.ToShortDateString());
        }
    }
}
