using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string
{
    public class LongestWord
    {
        public static void Main()
        {
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            string longest = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > longest.Length)
                    longest = words[i];
            }

            Console.WriteLine(longest);
        }
    }
}
