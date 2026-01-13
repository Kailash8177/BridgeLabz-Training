using System;
using System.Collections.Generic;
using System.Text;

namespace linear_binary_search
{
    internal class FindPeakElement
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            FindPeak(arr);
        }

        public static void FindPeak(int[] arr)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low < high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] < arr[mid + 1])
                    low = mid + 1;
                else
                    high = mid;
            }

            Console.WriteLine("Peak Element: " + arr[low]);
            Console.WriteLine("Peak Element Index: " + low);
        }
    }
}
