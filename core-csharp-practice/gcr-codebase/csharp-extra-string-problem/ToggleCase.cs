using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string
{
    public class ToggleCase
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch >= 'A' && ch <= 'Z')
                    result += (char)(ch + 32);
                else if (ch >= 'a' && ch <= 'z')
                    result += (char)(ch - 32);
                else
                    result += ch;
            }

            Console.WriteLine(result);
        }
    }
}
