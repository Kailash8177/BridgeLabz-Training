using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_builtin.level_2
{
    public class Factorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial: " + Fact(n));
        }
        public static int Fact(int n)
        {
            if (n == 0) return 1;
            return n * Fact(n - 1);
        }

    }
}
