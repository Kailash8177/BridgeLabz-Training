using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueHashMap
{
    public class SlidingWindowMax
    {
        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            LinkedList<int> deque = new LinkedList<int>();
            int[] result = new int[nums.Length - k + 1];
            int idx = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                // Remove indices out of current window
                if (deque.Count > 0 && deque.First.Value <= i - k)
                    deque.RemoveFirst();

                // Maintain decreasing order in deque
                while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
                    deque.RemoveLast();

                deque.AddLast(i);

                // Store result when window is complete
                if (i >= k - 1)
                    result[idx++] = nums[deque.First.Value];
            }

            return result;
        }
    }

    //  Logical Main class
    class SlidingWindowMaxDemo
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;

            Console.WriteLine("Input Array:");
            PrintArray(nums);

            int[] maxValues = SlidingWindowMax.MaxSlidingWindow(nums, k);

            Console.WriteLine($"\nSliding Window Maximum (k = {k}):");
            PrintArray(maxValues);
        }

        private static void PrintArray(int[] arr)
        {
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }

}
