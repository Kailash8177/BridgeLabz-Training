using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.array.level_2
{
    public class ReverseNumber
    {
        public static void Main()
        {

            int number = int.Parse(Console.ReadLine());

            int maxDigit = 10;
            int[] digits = new int[maxDigit];
            int index = 0;

            while (number != 0)
            {

                if (index == maxDigit)
                {
                    maxDigit = maxDigit + 10;
                    int[] temp = new int[maxDigit];

                    for (int i = 0; i < index; i++)
                    {
                        temp[i] = digits[i];
                    }

                    digits = temp;
                }

                digits[index] = number % 10;
                number = number / 10;
                index++;
            }

            for (int i = 0; i < index; i++)
            {
                Console.Write(digits[i]);
            }
        }
    }
}
