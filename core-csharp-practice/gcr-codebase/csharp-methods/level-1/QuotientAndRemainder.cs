using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    public class QuotientAndRemainder
    {
        public static void Main()
        {
            int number, divisor;
            int[] result;

            number = int.Parse(Console.ReadLine());
            divisor = int.Parse(Console.ReadLine());

            result = FindRemainderAndQuotient(number, divisor);

            Console.WriteLine("Quotient = " + result[0]);
            Console.WriteLine("Remainder = " + result[1]);
        }

        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int quotient = number / divisor;
            int remainder = number % divisor;
            int[] result = new int[2];
            result[0] = quotient;
            result[1] = remainder;
            return result;
        }


    }
}
