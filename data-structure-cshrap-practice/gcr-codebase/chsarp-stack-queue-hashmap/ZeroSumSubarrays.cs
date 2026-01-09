using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueHashMap
{
    public class ZeroSumSubarrays
    {
        public static void FindSubarrays(int[] arr)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            int sum = 0;

            // Handle subarrays starting from index 0
            map[0] = new List<int> { -1 };

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (map.ContainsKey(sum))
                {
                    foreach (int index in map[sum])
                    {
                        Console.WriteLine($"Subarray: {index + 1} to {i}");
                    }
                }

                if (!map.ContainsKey(sum))
                    map[sum] = new List<int>();

                map[sum].Add(i);
            }
        }
    }

    // 👇 Logical Main class
    class ZeroSumSubarraysDemo
    {
        public static void Main(string[] args)
        {
            int[] arr = { 6, 3, -1, -3, 4, -2, 2, 4, 6, -12, -7 };

            Console.WriteLine("Zero Sum Subarrays:");
            ZeroSumSubarrays.FindSubarrays(arr);
        }
    }
}
