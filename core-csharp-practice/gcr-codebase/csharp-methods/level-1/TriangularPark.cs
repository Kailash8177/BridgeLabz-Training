using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    public class TriangularPark
    {

        public static void Main()
        {
            double side1, side2, side3;
            double rounds;

            side1 = double.Parse(Console.ReadLine());
            side2 = double.Parse(Console.ReadLine());
            side3 = double.Parse(Console.ReadLine());

            rounds = CalculateRounds(side1, side2, side3);

            Console.WriteLine(rounds);
        }

        public static double CalculateRounds(double a, double b, double c)
        {
            double perimeter = a + b + c;
            double rounds = 5000 / perimeter;
            return rounds;
        }

    }
}
