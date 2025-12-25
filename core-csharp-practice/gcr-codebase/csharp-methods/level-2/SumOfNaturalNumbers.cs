using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_2
{
    public class SumOfNaturalNumbers
    {
        public static void Main()
        {
            int n;
            int sumRecursive, sumFormula;

            n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Not a Natural Number");
                return;
            }

            sumRecursive = SumUsingRecursion(n);
            sumFormula = SumUsingFormula(n);

            Console.WriteLine("Sum using recursion = " + sumRecursive);
            Console.WriteLine("Sum using formula = " + sumFormula);

            if (sumRecursive == sumFormula)
            {
                Console.WriteLine("Both methods give the same result.");
            }
            else
            {
                Console.WriteLine("Results do not match.");
            }
        }

        public static int SumUsingRecursion(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + SumUsingRecursion(n - 1);
            }
        }

        public static int SumUsingFormula(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}
