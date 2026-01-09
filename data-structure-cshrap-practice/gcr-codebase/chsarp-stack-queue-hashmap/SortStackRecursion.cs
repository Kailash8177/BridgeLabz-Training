using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueHashMap
{
    public class SortStackRecursion
    {
        public static void Sort(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int temp = stack.Pop();
                Sort(stack);
                InsertSorted(stack, temp);
            }
        }

        private static void InsertSorted(Stack<int> stack, int value)
        {
            if (stack.Count == 0 || stack.Peek() <= value)
            {
                stack.Push(value);
                return;
            }

            int temp = stack.Pop();
            InsertSorted(stack, value);
            stack.Push(temp);
        }
    }

    // Logical Main class
    class SortStackRecursionDemo
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(30);
            stack.Push(10);
            stack.Push(50);
            stack.Push(20);

            Console.WriteLine("Stack before sorting:");
            PrintStack(stack);

            SortStackRecursion.Sort(stack);

            Console.WriteLine("\nStack after sorting:");
            PrintStack(stack);
        }

        private static void PrintStack(Stack<int> stack)
        {
            foreach (int item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
