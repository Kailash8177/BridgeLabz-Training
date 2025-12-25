using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    public class SumOfNaturalNumbers
    {
        public static void Main()
        {
            int n;
            int result;

            n = int.Parse(Console.ReadLine());

            result = CalculateSum(n);

            Console.WriteLine(result);
        }
        public static int CalculateSum(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }

            return sum;
        }


    }
}
