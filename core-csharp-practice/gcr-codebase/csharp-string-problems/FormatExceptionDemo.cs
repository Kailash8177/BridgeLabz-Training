using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string.level_1
{
    public class FormatExceptionDemo
    {
        public static void Main()
        {
            try
            {
                string value = "abc";   // non-numeric string
                int number = int.Parse(value);

                Console.WriteLine("Number: " + number);
            }
            catch (FormatException e)   // System.FormatException
            {
                Console.WriteLine("Exception Caught: FormatException");

            }
        }
    }
}
