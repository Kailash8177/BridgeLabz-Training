using System;
using System.Collections.Generic;
using System.Text;

namespace linear_binary_search
{
    internal class ReverseString
    {
        public static void Main(string[] args)
        {
            Reverse();
        }

        static void Reverse()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Handle null or empty input
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be empty.");
                return;
            }

            StringBuilder sb = new StringBuilder(input);

            for (int i = 0, j = sb.Length - 1; i < j; i++, j--)
            {
                char temp = sb[i];
                sb[i] = sb[j];
                sb[j] = temp;
            }

            Console.WriteLine("Reversed String: " + sb.ToString());
        }
    }
}
