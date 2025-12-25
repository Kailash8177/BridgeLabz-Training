using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_3
{
    public class NumberChecker
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] digits = StoreDigits(number);

            Console.WriteLine("Digits count = " + digits.Length);

            Console.Write("Digits = ");
            for (int i = 0; i < digits.Length; i++)
            {
                Console.Write(digits[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));
            Console.WriteLine("Is Armstrong Number: " + IsArmstrongNumber(digits, number));

            int[] largest = FindLargestAndSecondLargest(digits);
            Console.WriteLine("Largest = " + largest[0] + ", Second Largest = " + largest[1]);

            int[] smallest = FindSmallestAndSecondSmallest(digits);
            Console.WriteLine("Smallest = " + smallest[0] + ", Second Smallest = " + smallest[1]);
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

        public static bool IsDuckNumber(int[] digits)
        {
            for (int i = 1; i < digits.Length; i++)
            {
                if (digits[i] != 0) return true;
            }
            return false;
        }

        public static bool IsArmstrongNumber(int[] digits, int number)
        {
            int sum = 0;
            int power = digits.Length;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += (int)Math.Pow(digits[i], power);
            }
            return sum == number;
        }

        public static int[] FindLargestAndSecondLargest(int[] digits)
        {
            int max1 = Int32.MinValue, max2 = Int32.MinValue;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] > max1)
                {
                    max2 = max1;
                    max1 = digits[i];
                }
                else if (digits[i] > max2)
                {
                    max2 = digits[i];
                }
            }
            return new int[] { max1, max2 };
        }

        public static int[] FindSmallestAndSecondSmallest(int[] digits)
        {
            int min1 = Int32.MaxValue, min2 = Int32.MaxValue;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] < min1)
                {
                    min2 = min1;
                    min1 = digits[i];
                }
                else if (digits[i] < min2)
                {
                    min2 = digits[i];
                }
            }
            return new int[] { min1, min2 };
        }
    }
}
