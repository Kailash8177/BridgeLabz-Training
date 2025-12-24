using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.array
{
    public class Multiplication
    {
        public static void Main()
        {
            int[] multiplicationResult = new int[4];
            int number = int.Parse(Console.ReadLine());

            int index = 0;
            for (int i = 6; i <= 9; i++)
            {
                multiplicationResult[index] = number * i;
                index++;
            }

            index = 0;
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + multiplicationResult[index]);
                index++;
            }
        }
    }
}
