using System;
using System.Collections.Generic;
using System.Text;

namespace linear_binary_search
{
    internal class FindOccurrence
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter sorted array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter target: ");
            int target = int.Parse(Console.ReadLine());

            FindFirstLastOccurrence(arr, target);
        }

        public static void FindFirstLastOccurrence(int[] arr, int target)
        {
            int first = -1;
            int last = -1;

            // Find First Occurrence
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == target)
                {
                    first = mid;
                    high = mid - 1; // move left
                }
                else if (arr[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            // Find Last Occurrence
            low = 0;
            high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == target)
                {
                    last = mid;
                    low = mid + 1; // move right
                }
                else if (arr[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            Console.WriteLine("First Occurrence: " + first);
            Console.WriteLine("Last Occurrence: " + last);
        }
    }
}
