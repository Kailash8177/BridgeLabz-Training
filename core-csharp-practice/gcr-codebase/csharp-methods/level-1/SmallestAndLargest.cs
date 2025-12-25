using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    public class SmallestAndLargest
    {
        public static void Main()
        {
            int number1, number2, number3;
            int[] result;

            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            number3 = int.Parse(Console.ReadLine());

            result = FindSmallestAndLargest(number1, number2, number3);

            Console.WriteLine("Smallest = " + result[0]);
            Console.WriteLine("Largest = " + result[1]);
        }
        public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
        {
            int smallest = number1;
            int largest = number1;

            if (number2 < smallest)
            {
                smallest = number2;
            }
            if (number3 < smallest)
            {
                smallest = number3;
            }

            if (number2 > largest)
            {
                largest = number2;
            }
            if (number3 > largest)
            {
                largest = number3;
            }

            int[] result = new int[2];
            result[0] = smallest;
            result[1] = largest;
            return result;
        }
    }
}
