using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_3
{
    public class NumberCheckerSecond
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] digits = StoreDigits(number);

            int sum = FindSum(digits);
            int sumSquares = FindSumSquares(digits);
            bool isHarshad = IsHarshad(number, sum);
            int[,] freq = DigitFrequency(digits);

            Console.WriteLine("Sum of digits = " + sum);
            Console.WriteLine("Sum of squares = " + sumSquares);
            Console.WriteLine("Is Harshad = " + isHarshad);

            Console.WriteLine("Digit Frequency:");
            for (int i = 0; i < 10; i++)
            {
                if (freq[i, 1] > 0)
                {
                    Console.WriteLine(i + " = " + freq[i, 1]);
                }
            }
        }

        public static int[] StoreDigits(int number)
        {
            int count = 0, temp = number;
            while (temp != 0)
            {
                count++;
                temp /= 10;
            }

            int[] digits = new int[count];
            temp = number;
            for (int i = count - 1; i >= 0; i--)
            {
                digits[i] = temp % 10;
                temp /= 10;
            }
            return digits;
        }

        public static int FindSum(int[] digits)
        {
            int sum = 0;
            for (int i = 0; i < digits.Length; i++) sum += digits[i];
            return sum;
        }

        public static int FindSumSquares(int[] digits)
        {
            int sum = 0;
            for (int i = 0; i < digits.Length; i++) sum += (int)Math.Pow(digits[i], 2);
            return sum;
        }

        public static bool IsHarshad(int number, int sum)
        {
            if (sum == 0) return false;
            return number % sum == 0;
        }

        public static int[,] DigitFrequency(int[] digits)
        {
            int[,] freq = new int[10, 2];
            for (int i = 0; i < 10; i++) freq[i, 0] = i;
            for (int i = 0; i < digits.Length; i++) freq[digits[i], 1]++;
            return freq;
        }
    }

}
