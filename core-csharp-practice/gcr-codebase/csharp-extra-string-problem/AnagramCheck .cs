using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string
{
    public class AnagramCheck
    {
        public static void Main()
        {
            string s1 = Console.ReadLine().ToLower();
            string s2 = Console.ReadLine().ToLower();

            if (s1.Length != s2.Length)
            {
                Console.WriteLine("Not Anagram");
                return;
            }

            int[] count = new int[256];

            for (int i = 0; i < s1.Length; i++)
            {
                count[s1[i]]++;
                count[s2[i]]--;
            }

            for (int i = 0; i < 256; i++)
            {
                if (count[i] != 0)
                {
                    Console.WriteLine("Not Anagram");
                    return;
                }
            }

            Console.WriteLine("Anagram");
        }
    }
}
