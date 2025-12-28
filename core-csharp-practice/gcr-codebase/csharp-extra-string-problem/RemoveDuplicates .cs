using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string
{
    public class RemoveDuplicates
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                    result += str[i];
            }

            Console.WriteLine(result);
        }
    }
}
