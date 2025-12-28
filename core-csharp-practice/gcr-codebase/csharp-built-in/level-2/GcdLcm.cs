using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_builtin.level_2
{
    public class GcdLcm
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("GCD: " + GCD(a, b));
            Console.WriteLine("LCM: " + LCM(a, b));
        }
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
    }
}
