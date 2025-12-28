using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string
{
    public class MostFrequentChar
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            int max = 0;
            char result = str[0];

            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                        count++;
                }
                if (count > max)
                {
                    max = count;
                    result = str[i];
                }
            }

            Console.WriteLine("Most Frequent Character: " + result);
        }
    }
}
