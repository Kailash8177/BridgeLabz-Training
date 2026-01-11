using System;
using System.Collections.Generic;
using System.Text;

namespace sorting_algorithms
{
    internal class ProductPrices
    {
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        public static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int swap = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = swap;

            return i + 1;
        }

        public static void Main()
        {
            int[] prices = { 1200, 500, 1500, 800, 300 };
            QuickSort(prices, 0, prices.Length - 1);

            Console.WriteLine("Sorted Product Prices:");
            foreach (int price in prices)
                Console.Write(price + " ");
        }
    }
}
