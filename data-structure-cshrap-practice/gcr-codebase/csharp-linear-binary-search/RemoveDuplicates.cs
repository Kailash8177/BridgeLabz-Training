using System;
using System.Collections.Generic;
using System.Text;

namespace linear_binary_search
{
    internal class RemoveDuplicate
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be empty.");
                return;
            }

            string result = RemoveDuplicates(input);
            Console.WriteLine("After Removing Duplicates: " + result);
        }

        public static string RemoveDuplicates(string input)
        {
            StringBuilder sb = new StringBuilder();
            HashSet<char> seen = new HashSet<char>();

            foreach (char c in input)
            {
                if (!seen.Contains(c))
                {
                    seen.Add(c);
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}
