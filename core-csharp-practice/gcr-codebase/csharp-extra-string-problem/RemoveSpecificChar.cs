using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string
{
    public class RemoveSpecificChar
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            char ch = Console.ReadLine()[0];
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ch)
                    result += str[i];
            }

            Console.WriteLine(result);
        }
    }
}
