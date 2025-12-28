using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_builtin.level_1
{
    public class DateComparison
    {
        public static void Main()
        {

            DateTime date1 = DateTime.Parse(Console.ReadLine());
            DateTime date2 = DateTime.Parse(Console.ReadLine());
            if (date1 < date2)
                Console.WriteLine("First date is BEFORE second date");
            else if (date1 > date2)
                Console.WriteLine("First date is AFTER second date");
            else
                Console.WriteLine("Both dates are SAME");
        }
    }
}
