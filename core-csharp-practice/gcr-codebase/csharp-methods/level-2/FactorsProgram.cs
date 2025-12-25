using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_2
{
    public class FactorsProgram
    {
        public static void Main()
        {
            int number;
            int[] factors;
            int sum, product;
            double sumOfSquares;

            number = int.Parse(Console.ReadLine());

            factors = FindFactors(number);

            Console.Write("Factors = ");
            for (int i = 0; i < factors.Length; i++)
            {
                Console.Write(factors[i] + " ");
            }
            Console.WriteLine();

            sum = SumOfFactors(factors);
            product = ProductOfFactors(factors);
            sumOfSquares = SumOfSquareOfFactors(factors);

            Console.WriteLine("Sum of factors = " + sum);
            Console.WriteLine("Product of factors = " + product);
            Console.WriteLine("Sum of square of factors = " + sumOfSquares);
        }

        public static int[] FindFactors(int number)
        {
            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }

            int[] factors = new int[count];
            int index = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index] = i;
                    index++;
                }
            }

            return factors;
        }

        public static int SumOfFactors(int[] factors)
        {
            int sum = 0;
            for (int i = 0; i < factors.Length; i++)
            {
                sum += factors[i];
            }
            return sum;
        }

        public static int ProductOfFactors(int[] factors)
        {
            int product = 1;
            for (int i = 0; i < factors.Length; i++)
            {
                product *= factors[i];
            }
            return product;
        }

        public static double SumOfSquareOfFactors(int[] factors)
        {
            double sum = 0;
            for (int i = 0; i < factors.Length; i++)
            {
                sum += Math.Pow(factors[i], 2);
            }
            return sum;
        }
    }
}
