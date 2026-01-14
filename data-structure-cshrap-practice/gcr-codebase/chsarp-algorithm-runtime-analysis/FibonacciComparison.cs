using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm_runtime_analysis
{
    internal class FibonacciComparison
    {
        // O(2^N)
        static int FibonacciRecursive(int n)
        {
            if (n <= 1) return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        // O(N)
        static int FibonacciIterative(int n)
        {
            if (n <= 1) return n;

            int a = 0, b = 1, sum = 0;
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }

        static void Main()
        {
            int n = 40;

            var sw = System.Diagnostics.Stopwatch.StartNew();
            FibonacciRecursive(n);
            sw.Stop();
            Console.WriteLine($"Recursive: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            FibonacciIterative(n);
            sw.Stop();
            Console.WriteLine($"Iterative: {sw.ElapsedMilliseconds} ms");
        }
    }
}
