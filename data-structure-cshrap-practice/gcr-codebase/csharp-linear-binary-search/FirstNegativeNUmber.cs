using System;
using System.Collections.Generic;
using System.Text;

namespace linear_binary_search
{
    internal class FirstNegativeNumber
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            FirstNegative(arr);
        }

        static void FirstNegative(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine("First Negative Number: " + arr[i]);
                    return;
                }
            }

            Console.WriteLine("No negative number found.");
        }
    }
}
