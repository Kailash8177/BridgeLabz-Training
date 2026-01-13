using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace linear_binary_search
{
    internal class ComparePerformances
    {
        public static void Main(string[] args)
        {
            ComparePerformance(100000);
        }

        static void ComparePerformance(int iterations)
        {
            // Using string
            Stopwatch sw1 = Stopwatch.StartNew();
            string str = "";
            for (int i = 0; i < iterations; i++)
            {
                str += "a";
            }
            sw1.Stop();

            // Using StringBuilder
            Stopwatch sw2 = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iterations; i++)
            {
                sb.Append("a");
            }
            sw2.Stop();

            Console.WriteLine($"String Time        : {sw1.ElapsedMilliseconds} ms");
            Console.WriteLine($"StringBuilder Time : {sw2.ElapsedMilliseconds} ms");
        }
    }
}
