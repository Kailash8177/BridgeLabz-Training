using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string
{
    public class CountVowelsConsonants
    {
        public static void Main()
        {
            string str = Console.ReadLine().ToLower();
            int vowels = 0, consonants = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch >= 'a' && ch <= 'z')
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                        vowels++;
                    else
                        consonants++;
                }
            }

            Console.WriteLine("Vowels: " + vowels);
            Console.WriteLine("Consonants: " + consonants);
        }
    }
}
