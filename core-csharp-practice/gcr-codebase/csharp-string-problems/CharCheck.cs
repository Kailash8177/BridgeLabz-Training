using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string.level_1
{
    public class CharCheck
    {
        public static char[] GetCharsWithoutToCharArray(string input)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                result[i] = input[i];
            }

            return result;
        }

        public static char[] GetCharsUsingToCharArray(string input)
        {
            return input.ToCharArray();
        }

        public static void Main(string[] args)
        {
            string str = "HelloWorld";

            char[] chars1 = GetCharsWithoutToCharArray(str);

            Console.WriteLine("Without ToCharArray():");
            foreach (char c in chars1)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine("\n");

            char[] chars2 = GetCharsUsingToCharArray(str);

            Console.WriteLine("Using ToCharArray():");
            foreach (char c in chars2)
            {
                Console.Write(c + " ");
            }
        }
    }
}
