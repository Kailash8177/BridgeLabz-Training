using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueHashMap
{
    public class LongestConsecutive
    {
        public static int FindLongest(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int longest = 0;

            foreach (int num in nums)
            {
                // Start counting only if this is the beginning of a sequence
                if (!set.Contains(num - 1))
                {
                    int current = num;
                    int count = 1;

                    while (set.Contains(current + 1))
                    {
                        current++;
                        count++;
                    }

                    longest = Math.Max(longest, count);
                }
            }

            return longest;
        }
    }

    // 👇 Logical Main class
    class LongestConsecutiveDemo
    {
        public static void Main(string[] args)
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };

            Console.WriteLine("Array:");
            PrintArray(nums);

            int result = LongestConsecutive.FindLongest(nums);

            Console.WriteLine("\nLength of Longest Consecutive Sequence: " + result);
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
