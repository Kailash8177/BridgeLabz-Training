using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    public class ChocolateDivision
    {
        public static void Main()
        {
            int numberOfChocolates, numberOfChildren;
            int[] result;

            numberOfChocolates = int.Parse(Console.ReadLine());
            numberOfChildren = int.Parse(Console.ReadLine());

            result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

            Console.WriteLine("Chocolates each child gets = " + result[0]);
            Console.WriteLine("Remaining chocolates = " + result[1]);
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
