using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.array.level_2
{
    public class Reverse
    {
        public static void Main()
        {

            int number = int.Parse(Console.ReadLine());
            int temp = number;
            int count = 0;

            while (temp != 0)
            {
                count++;
                temp = temp / 10;
            }

            int[] digits = new int[count];
            temp = number;

            for (int i = 0; i < count; i++)
            {
                digits[i] = temp % 10;
                temp = temp / 10;
            }

            int[] reverse = new int[count];

            for (int i = 0; i < count; i++)
            {
                reverse[i] = digits[count - 1 - i];
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write(reverse[i]);
            }
        }
    }
}
