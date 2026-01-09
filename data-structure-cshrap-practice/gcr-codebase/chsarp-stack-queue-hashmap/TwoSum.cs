using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueHashMap
{
    public class TwoSum
    {
        public static int[] FindTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                    return new int[] { map[complement], i };

                map[nums[i]] = i;
            }

            return new int[0];
        }
    }

    //  Logical Main class
    class TwoSumDemo
    {
        public static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            Console.WriteLine("Array:");
            PrintArray(nums);

            int[] result = TwoSum.FindTwoSum(nums, target);

            if (result.Length == 2)
                Console.WriteLine($"\nIndices found: {result[0]} and {result[1]}");
            else
                Console.WriteLine("\nNo valid pair found");
        }

        private static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
