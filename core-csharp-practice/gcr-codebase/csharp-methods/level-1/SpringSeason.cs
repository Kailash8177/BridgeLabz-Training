using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    public class SpringSeason
    {
        public static void Main(string[] args)
        {
            int month;
            int day;
            bool result;

            month = int.Parse(args[0]);
            day = int.Parse(args[1]);

            result = IsSpringSeason(month, day);

            if (result)
            {
                Console.WriteLine("Its a Spring Season");
            }
            else
            {
                Console.WriteLine("Not a Spring Season");
            }
        }
        public static bool IsSpringSeason(int month, int day)
        {
            if ((month == 3 && day >= 20) ||
               (month == 4) ||
               (month == 5) ||
               (month == 6 && day <= 20))
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
