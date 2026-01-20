using System;
using System.Linq;

class CountingSortProgram
{
    static void Main()
    {
        // Input array (non-negative integers)
        int[] arr = { 10, 1, 2, 4, 7 };

        Console.WriteLine("Before Sorting:");
        PrintArray(arr);

        // Call Counting Sort
        Sort(arr);

        Console.WriteLine("\nAfter Sorting:");
        PrintArray(arr);
    }

    // Counting Sort Method
    static void Sort(int[] arr)
    {
        int n = arr.Length;

        /* ================= STEP 1 =================
           Find the maximum element in the array
           This decides the size of the count array
        */
        int max = arr.Max();

        /* ================= STEP 2 =================
           Create count array
           Index -> element value
           Value -> frequency of that element
        */
        int[] count = new int[max + 1];

        /* ================= STEP 3 =================
           Store frequency of each element
        */
        for (int i = 0; i < n; i++)
            count[arr[i]]++;

        /* ================= STEP 4 =================
           Convert frequency array to prefix sum array
           count[i] now stores the final position of element i
        */
        for (int i = 1; i <= max; i++)
            count[i] += count[i - 1];

        /* ================= STEP 5 =================
           Create output array to store sorted elements
        */
        int[] output = new int[n];

        /* ================= STEP 6 =================
           Build output array from RIGHT to LEFT
           This ensures stability of Counting Sort
        */
        for (int i = n - 1; i >= 0; i--)
        {
            output[count[arr[i]] - 1] = arr[i];
            count[arr[i]]--;
        }

        /* ================= STEP 7 =================
           Copy sorted elements back to original array
        */
        for (int i = 0; i < n; i++)
            arr[i] = output[i];
    }

    // Helper method to print array
    static void PrintArray(int[] arr)
    {
        foreach (int val in arr)
            Console.Write(val + " ");
        Console.WriteLine();
    }
}
