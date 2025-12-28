using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_builtin.level_2
{
    public class PrimeCheck
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n) ? "Prime" : "Not Prime");
        }
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
