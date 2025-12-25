using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_2
{
    internal class RandomNumbers
    {
        public static void Main()
        {
            int[] numbers = Generate4DigitRandomArray(5);
            double[] result = FindAverageMinMax(numbers);

            Console.Write("Generated numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Average = " + result[0]);
            Console.WriteLine("Minimum = " + result[1]);
            Console.WriteLine("Maximum = " + result[2]);
        }

        public static int[] Generate4DigitRandomArray(int size)
        {
            int[] numbers = new int[size];
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                numbers[i] = rand.Next(1000, 10000); // 4-digit number
            }
            return numbers;
        }

        public static double[] FindAverageMinMax(int[] numbers)
        {
            int sum = 0;
            int min = numbers[0];
            int max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                min = Math.Min(min, numbers[i]);
                max = Math.Max(max, numbers[i]);
            }

            double average = sum / (double)numbers.Length;
            return new double[] { average, min, max };
        }
    }
}
