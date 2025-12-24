using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.array
{
    public class OddEvenArray
    {
        public static void Main()
        {

            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Invalid Number");
                return;
            }

            int[] even = new int[number / 2 + 1];
            int[] odd = new int[number / 2 + 1];

            int e = 0;
            int o = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    even[e] = i;
                    e++;
                }
                else
                {
                    odd[o] = i;
                    o++;
                }
            }

            for (int i = 0; i < o; i++)
            {
                Console.Write(odd[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < e; i++)
            {
                Console.Write(even[i] + " ");
            }
        }
    }
}
