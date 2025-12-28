using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_builtin.level_2
{
    public class Palindrome
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(IsPalindrome(input) ? "Palindrome" : "Not Palindrome");
        }
        public static bool IsPalindrome(string str)
        {
            int start = 0, end = str.Length - 1;
            while (start < end)
            {
                if (str[start] != str[end])
                    return false;
                start++;
                end--;
            }
            return true;
        }

    }
}
