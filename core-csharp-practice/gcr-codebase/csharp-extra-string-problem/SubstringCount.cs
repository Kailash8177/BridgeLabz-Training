using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string
{
    public class SubstringCount
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            string sub = Console.ReadLine();
            int count = 0;

            for (int i = 0; i <= str.Length - sub.Length; i++)
            {
                int j;
                for (j = 0; j < sub.Length; j++)
                {
                    if (str[i + j] != sub[j])
                        break;
                }
                if (j == sub.Length)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
