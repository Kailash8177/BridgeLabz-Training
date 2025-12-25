using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_3
{
    public class NumberCheckerThird
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] digits = StoreDigits(number);

            int[] reversed = ReverseDigits(digits);
            bool isPalindrome = CompareArrays(digits, reversed);
            bool isDuck = IsDuckNumber(digits);

            Console.WriteLine("Original Digits: ");
            for (int i = 0; i < digits.Length; i++) Console.Write(digits[i] + " ");
            Console.WriteLine();

            Console.WriteLine("Reversed Digits: ");
            for (int i = 0; i < reversed.Length; i++) Console.Write(reversed[i] + " ");
            Console.WriteLine();

            Console.WriteLine("Is Palindrome = " + isPalindrome);
            Console.WriteLine("Is Duck Number = " + isDuck);
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

        public static int[] ReverseDigits(int[] digits)
        {
            int[] rev = new int[digits.Length];
            for (int i = 0; i < digits.Length; i++) rev[i] = digits[digits.Length - 1 - i];
            return rev;
        }

        public static bool CompareArrays(int[] a, int[] b)
        {
            if (a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }

        public static bool IsDuckNumber(int[] digits)
        {
            for (int i = 1; i < digits.Length; i++) if (digits[i] != 0) return true;
            return false;
        }
    }
}
