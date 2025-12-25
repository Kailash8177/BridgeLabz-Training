using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    public class CheckNumber
    {
        public static void Main()
        {
            int number;
            int result;

            number = int.Parse(Console.ReadLine());

            result = Check(number);

            Console.WriteLine(result);
        }
        public static int Check(int n)
        {
            if (n > 0)
            {
                return 1;
            }
            else if (n < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
