using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm_runtime_analysis
{
    internal class SortingComparison
    {
        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // O(N log N)
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left >= right) return;

            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }

        static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];
            int i = left, j = mid + 1, k = 0;

            while (i <= mid && j <= right)
                temp[k++] = arr[i] <= arr[j] ? arr[i++] : arr[j++];

            while (i <= mid) temp[k++] = arr[i++];
            while (j <= right) temp[k++] = arr[j++];

            Array.Copy(temp, 0, arr, left, temp.Length);
        }

        // O(N log N)
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low >= high) return;

            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);

            QuickSort(arr, low, i);
            QuickSort(arr, i + 2, high);
        }

        static void Main()
        {
            int N = 10000;
            Random rand = new Random();
            int[] arr = new int[N];

            for (int i = 0; i < N; i++) arr[i] = rand.Next();

            var copy1 = (int[])arr.Clone();
            var copy2 = (int[])arr.Clone();

            var sw = System.Diagnostics.Stopwatch.StartNew();
            BubbleSort(arr);
            sw.Stop();
            Console.WriteLine($"Bubble Sort: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            MergeSort(copy1, 0, copy1.Length - 1);
            sw.Stop();
            Console.WriteLine($"Merge Sort: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            QuickSort(copy2, 0, copy2.Length - 1);
            sw.Stop();
            Console.WriteLine($"Quick Sort: {sw.ElapsedMilliseconds} ms");
        }
    }
}
