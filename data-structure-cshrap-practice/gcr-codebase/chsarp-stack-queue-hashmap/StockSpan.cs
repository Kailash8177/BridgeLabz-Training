using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueHashMap
{
    public class StockSpan
    {
        public static int[] CalculateSpan(int[] prices)
        {
            int n = prices.Length;
            int[] span = new int[n];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
                {
                    stack.Pop();
                }

                span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());
                stack.Push(i);
            }

            return span;
        }
    }

    //  Logical Main class
    class StockSpanDemo
    {
        public static void Main(string[] args)
        {
            int[] prices = { 100, 80, 60, 70, 60, 75, 85 };

            Console.WriteLine("Stock Prices:");
            PrintArray(prices);

            int[] span = StockSpan.CalculateSpan(prices);

            Console.WriteLine("\nStock Span:");
            PrintArray(span);
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
