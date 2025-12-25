using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_3
{
    public class NumberCheckerFive
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] factors = FindFactors(number);

            Console.Write("Factors: ");
            for (int i = 0; i < factors.Length; i++) Console.Write(factors[i] + " ");
            Console.WriteLine();

            Console.WriteLine("Greatest Factor = " + FindGreatestFactor(factors));
            Console.WriteLine("Sum of Factors = " + SumFactors(factors));
            Console.WriteLine("Product of Factors = " + ProductFactors(factors));
            Console.WriteLine("Product of Cube of Factors = " + ProductCubeFactors(factors));
            Console.WriteLine("Is Perfect = " + IsPerfect(number, factors));
            Console.WriteLine("Is Abundant = " + IsAbundant(number, factors));
            Console.WriteLine("Is Deficient = " + IsDeficient(number, factors));
            Console.WriteLine("Is Strong = " + IsStrong(number));
        }

        public static int[] FindFactors(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++) if (number % i == 0) count++;

            int[] factors = new int[count];
            int index = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index++] = i;
                }
            }
            return factors;
        }

        public static int FindGreatestFactor(int[] factors)
        {
            int max = factors[0];
            for (int i = 1; i < factors.Length; i++) if (factors[i] > max) max = factors[i];
            return max;
        }

        public static int SumFactors(int[] factors)
        {
            int sum = 0;
            for (int i = 0; i < factors.Length; i++) sum += factors[i];
            return sum;
        }

        public static long ProductFactors(int[] factors)
        {
            long prod = 1;
            for (int i = 0; i < factors.Length; i++) prod *= factors[i];
            return prod;
        }

        public static double ProductCubeFactors(int[] factors)
        {
            double prod = 1;
            for (int i = 0; i < factors.Length; i++) prod *= Math.Pow(factors[i], 3);
            return prod;
        }

        public static bool IsPerfect(int number, int[] factors)
        {
            int sum = 0;
            for (int i = 0; i < factors.Length - 1; i++) sum += factors[i]; // exclude number itself
            return sum == number;
        }

        public static bool IsAbundant(int number, int[] factors)
        {
            int sum = 0;
            for (int i = 0; i < factors.Length - 1; i++) sum += factors[i];
            return sum > number;
        }

        public static bool IsDeficient(int number, int[] factors)
        {
            int sum = 0;
            for (int i = 0; i < factors.Length - 1; i++) sum += factors[i];
            return sum < number;
        }

        public static bool IsStrong(int number)
        {
            int[] digits = StoreDigits(number);
            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += Factorial(digits[i]);
            }
            return sum == number;
        }

        public static int[] StoreDigits(int number)
        {
            int count = 0, temp = number;
            while (temp != 0) { count++; temp /= 10; }
            int[] digits = new int[count];
            temp = number;
            for (int i = count - 1; i >= 0; i--) { digits[i] = temp % 10; temp /= 10; }
            return digits;
        }

        public static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++) fact *= i;
            return fact;
        }
    }
}
