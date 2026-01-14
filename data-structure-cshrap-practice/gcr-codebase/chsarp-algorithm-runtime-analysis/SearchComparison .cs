using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm_runtime_analysis
{
    internal class SearchComparison
    {
        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }

        // O(log N) – array must be sorted
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target) return mid;
                if (arr[mid] < target) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }

        static void Main()
        {
            int N = 1_000_000;
            int[] arr = new int[N];
            for (int i = 0; i < N; i++) arr[i] = i;

            int target = N - 1;

            var sw = System.Diagnostics.Stopwatch.StartNew();
            LinearSearch(arr, target);
            sw.Stop();
            Console.WriteLine($"Linear Search: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            BinarySearch(arr, target);
            sw.Stop();
            Console.WriteLine($"Binary Search: {sw.ElapsedMilliseconds} ms");
        }
    }
}
