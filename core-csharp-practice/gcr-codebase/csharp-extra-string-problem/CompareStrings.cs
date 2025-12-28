using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string
{
    public class CompareStrings
    {
        public static void Main()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            int min = s1.Length < s2.Length ? s1.Length : s2.Length;

            for (int i = 0; i < min; i++)
            {
                if (s1[i] < s2[i])
                {
                    Console.WriteLine(s1 + " comes before " + s2);
                    return;
                }
                else if (s1[i] > s2[i])
                {
                    Console.WriteLine(s2 + " comes before " + s1);
                    return;
                }
            }

            if (s1.Length < s2.Length)
                Console.WriteLine(s1 + " comes before " + s2);
            else if (s1.Length > s2.Length)
                Console.WriteLine(s2 + " comes before " + s1);
            else
                Console.WriteLine("Both strings are equal");
        }
    }
}
