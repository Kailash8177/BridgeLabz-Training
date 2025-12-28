using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string.level_1
{
    public class ArrayIndexOutOfRangeDemo
    {
        public static void Main()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException occurred");
            }
        }
    }
}
