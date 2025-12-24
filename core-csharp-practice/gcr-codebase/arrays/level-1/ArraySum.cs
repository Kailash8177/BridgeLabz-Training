using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.array
{
    public class ArraySum
    {
        public static void Main()
        {
            double[] numbers = new double[10];
            double total = 0.0;
            int index = 0;
            while (true)
            {
                Console.WriteLine("Enter a number:");
                double value = double.Parse(Console.ReadLine());
                if (value <= 0)
                {
                    break;
                }
                if (index == 10)
                {
                    break;
                }

                numbers[index] = value;
                index++;
            }
            Console.WriteLine("Numbers entered:");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(numbers[i]);
                total += numbers[i];
            }
            Console.WriteLine("Total Sum = " + total);
        }
    }
}
