using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string.level_1
{
    public class SubString
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            string customSub = "";
            if (start + end < str.Length)
            {
                customSub = CreateSubstring(str, start, start + end);
            }
            else
            {
                Console.WriteLine("End index exceeds string length.");
            }
            string builtInSub = str.Substring(start, end);

            Console.WriteLine(customSub);
            Console.WriteLine(builtInSub);
        }

        public static string CreateSubstring(string s, int start, int end)
        {
            string result = "";

            for (int i = start; i <= end; i++)
            {
                result = result + s[i];
            }

            return result;
        }
    }
}
