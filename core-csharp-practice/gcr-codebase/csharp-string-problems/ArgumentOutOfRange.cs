using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string.level_1
{
    public class ArgumentOutOfRange
    {
        public static void Main()
        {
            try
            {
                string text = "Hello";
                Console.WriteLine(text.Substring(6, 2));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("ArgumentOutOfRangeException occurred");
            }
        }
    }
}
