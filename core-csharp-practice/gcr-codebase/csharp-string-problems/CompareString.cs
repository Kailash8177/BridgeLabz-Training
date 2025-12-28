using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string.level_1
{
    public class CompareString
    {
        public static void Main()
        {
            String str1 = Console.ReadLine();
            String str2 = Console.ReadLine();
            bool customResult = CompareStringsCharByChar(str1, str2);
            bool builtInResult = str1.Equals(str2);
            Console.WriteLine("Custom Comparison Result: " + customResult);
            Console.WriteLine("Built-in Comparison Result: " + builtInResult);
        }
        public static bool CompareStringsCharByChar(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
