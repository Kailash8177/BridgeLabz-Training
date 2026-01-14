using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm_runtime_analysis
{
    internal class StringConcatenation
    {
        static void Main()
        {
            int N = 100000;

            var sw = System.Diagnostics.Stopwatch.StartNew();
            string s = "";
            for (int i = 0; i < N; i++)
                s += "A";
            sw.Stop();
            Console.WriteLine($"String: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < N; i++)
                sb.Append("A");
            sw.Stop();
            Console.WriteLine($"StringBuilder: {sw.ElapsedMilliseconds} ms");
        }
    }
}
