using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.array
{
    public class NumberCheck
    {
        public static void Main()
        {
            int[] numbers = new int[5];
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.WriteLine(numbers[i] + " is Positive and Even");
                    }
                    else
                    {
                        Console.WriteLine(numbers[i] + " is Positive and Odd");
                    }
                }
                else if (numbers[i] < 0)
                {
                    Console.WriteLine(numbers[i] + " is Negative");
                }
                else
                {
                    Console.WriteLine(numbers[i] + " is Zero");
                }
            }
            if (numbers[0] == numbers[numbers.Length - 1])
            {
                Console.WriteLine("First and last elements are Equal");
            }
            else if (numbers[0] > numbers[numbers.Length - 1])
            {
                Console.WriteLine("First element is Greater than last element");
            }
            else
            {
                Console.WriteLine("First element is Less than last element");
            }
        }
    }
}
