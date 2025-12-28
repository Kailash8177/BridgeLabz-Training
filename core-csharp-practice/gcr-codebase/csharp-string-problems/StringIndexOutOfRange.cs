using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string.level_1
{
    public class StringIndexOutOfRange
    {
        public static void Main()
        {
            try
            {
                string text = "Hello";
                Console.WriteLine(text[10]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException occurred");
            }
        }
    }
}
