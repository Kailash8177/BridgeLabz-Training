using System;
using System.Collections.Generic;
using System.Text;

namespace linear_binary_search
{
    internal class FindRotationPoint
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter rotated sorted array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            FindRotationPoints(arr);
        }

        public static void FindRotationPoints(int[] arr)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low < high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] > arr[high])
                    low = mid + 1;
                else
                    high = mid;
            }

            Console.WriteLine("Rotation Point Index: " + low);
            Console.WriteLine("Rotation Point Value: " + arr[low]);
        }
    }
}
