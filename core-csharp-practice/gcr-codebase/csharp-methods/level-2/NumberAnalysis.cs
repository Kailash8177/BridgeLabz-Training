using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_2
{
    public class NumberAnalysis
    {

        public static void Main()
        {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsPositive(numbers[i]))
                {
                    Console.Write(numbers[i] + " is positive and ");
                    if (IsEven(numbers[i]))
                    {
                        Console.WriteLine("even");
                    }
                    else
                    {
                        Console.WriteLine("odd");
                    }
                }
                else
                {
                    Console.WriteLine(numbers[i] + " is negative");
                }
            }

            int comparison = Compare(numbers[0], numbers[4]);
            if (comparison == 1)
            {
                Console.WriteLine("First number is greater than last number");
            }
            else if (comparison == -1)
            {
                Console.WriteLine("First number is less than last number");
            }
            else
            {
                Console.WriteLine("First number is equal to last number");
            }
        }

        public static bool IsPositive(int number)
        {
            return number >= 0;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static int Compare(int number1, int number2)
        {
            if (number1 > number2)
            {
                return 1;
            }
            else if (number1 < number2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }
}
