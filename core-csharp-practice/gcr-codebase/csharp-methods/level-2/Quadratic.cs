using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_2
{
    public class Quadratic
    {
        public static void Main()
        {
            double a, b, c;
            double[] roots;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            roots = FindRoots(a, b, c);

            if (roots.Length == 0)
            {
                Console.WriteLine("No real roots");
            }
            else if (roots.Length == 1)
            {
                Console.WriteLine("One root: " + roots[0]);
            }
            else
            {
                Console.WriteLine("Two roots: " + roots[0] + " and " + roots[1]);
            }
        }

        public static double[] FindRoots(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return new double[] { root1, root2 };
            }
            else if (delta == 0)
            {
                double root = -b / (2 * a);
                return new double[] { root };
            }
            else
            {
                return new double[0];
            }
        }
    }
}
