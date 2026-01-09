using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueHashMap
{

    public class PairSum
    {
        public static bool HasPair(int[] arr, int target)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in arr)
            {
                if (set.Contains(target - num))
                    return true;

                set.Add(num);
            }
            return false;
        }
    }

    //  Logical Main class
    class PairSumDemo
    {
        public static void Main(string[] args)
        {
            int[] arr = { 8, 7, 2, 5, 3, 1 };
            int target = 10;

            Console.WriteLine("Array:");
            PrintArray(arr);

            bool result = PairSum.HasPair(arr, target);

            Console.WriteLine($"\nTarget Sum: {target}");
            Console.WriteLine(result
                ? "Pair exists with given sum"
                : "No pair exists with given sum");
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
