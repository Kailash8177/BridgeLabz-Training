using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_3
{
    public class NumberCheckerFourth
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] digits = NumberToDigits(number);

            Console.WriteLine("Is Prime = " + IsPrime(number));
            Console.WriteLine("Is Neon = " + IsNeon(number));
            Console.WriteLine("Is Spy = " + IsSpy(digits));
            Console.WriteLine("Is Automorphic = " + IsAutomorphic(number));
            Console.WriteLine("Is Buzz = " + IsBuzz(number));
        }

        public static int[] NumberToDigits(int number)
        {
            int count = 0, temp = number;
            while (temp != 0) { count++; temp /= 10; }
            int[] digits = new int[count];
            temp = number;
            for (int i = count - 1; i >= 0; i--) { digits[i] = temp % 10; temp /= 10; }
            return digits;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static bool IsNeon(int number)
        {
            int sq = number * number;
            int sum = 0;
            while (sq != 0) { sum += sq % 10; sq /= 10; }
            return sum == number;
        }

        public static bool IsSpy(int[] digits)
        {
            int sum = 0, prod = 1;
            for (int i = 0; i < digits.Length; i++) { sum += digits[i]; prod *= digits[i]; }
            return sum == prod;
        }

        public static bool IsAutomorphic(int number)
        {
            int sq = number * number;
            string numStr = number.ToString();
            string sqStr = sq.ToString();
            return sqStr.EndsWith(numStr);
        }

        public static bool IsBuzz(int number)
        {
            return number % 7 == 0 || number % 10 == 7;
        }
    }
}
