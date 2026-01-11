using System;
using System.Collections.Generic;
using System.Text;

namespace sorting_algorithms
{
    internal class Salaries
    {
        public static void HeapSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }
        }

        public static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, n, largest);
            }
        }

        public static void Main()
        {
            int[] salaries = { 45000, 70000, 30000, 60000, 50000 };
            HeapSort(salaries);

            Console.WriteLine("Sorted Salaries:");
            foreach (int salary in salaries)
                Console.Write(salary + " ");
        }
    }
}
