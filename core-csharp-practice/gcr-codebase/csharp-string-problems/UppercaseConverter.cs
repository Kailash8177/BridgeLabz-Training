using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string.level_1
{
    public class UppercaseConverter
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if (ch >= 'a' && ch <= 'z')
                    result[i] = (char)(ch - 32);
                else
                    result[i] = ch;
            }

            Console.WriteLine("ASCII Uppercase: " + new string(result));
            Console.WriteLine("Built-in Uppercase: " + text.ToUpper());
        }
    }
}
