using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.array
{
    public class MultiplicationTable
    {
        public static void Main()
        {

            int number;
            int[] table = new int[10];

            Console.WriteLine("Enter a number:");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                table[i - 1] = number * i;
            }
            Console.WriteLine("Multiplication Table of " + number + ":");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + table[i - 1]);
            }
        }
    }
}
