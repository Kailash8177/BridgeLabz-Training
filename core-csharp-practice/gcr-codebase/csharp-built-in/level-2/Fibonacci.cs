using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_builtin.level_2
{
    public class Fibonacci
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintFibonacci(n);
        }
        public static void PrintFibonacci(int n)
        {
            int a = 0, b = 1, c;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
        }

    }
}
