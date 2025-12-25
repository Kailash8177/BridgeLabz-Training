using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    public class Handshakes
    {
        public static void Main()
        {
            int n;
            int result;

            n = int.Parse(Console.ReadLine());

            result = CalculateHandshakes(n);

            Console.WriteLine(result);
        }
        public static int CalculateHandshakes(int n)
        {
            int handshakes = (n * (n - 1)) / 2;
            return handshakes;
        }
    }
}
