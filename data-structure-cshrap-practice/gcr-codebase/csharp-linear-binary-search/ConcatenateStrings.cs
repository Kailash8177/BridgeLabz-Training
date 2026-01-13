using System;
using System.Collections.Generic;
using System.Text;

namespace linear_binary_search
{
    internal class ConcatenateStrings
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of strings: ");
            int n = int.Parse(Console.ReadLine());

            string[] inputs = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter string {i + 1}: ");
                inputs[i] = Console.ReadLine();
            }

            string result = ConcatenateString(inputs);
            Console.WriteLine("Concatenated String: " + result);
        }

        public static string ConcatenateString(string[] inputs)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string s in inputs)
            {
                sb.Append(s);
            }

            return sb.ToString();
        }
    }
}
