using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_3
{
    public class DistanceLineProgram
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double distance = EuclideanDistance(x1, y1, x2, y2);
            double[] line = LineEquation(x1, y1, x2, y2);

            Console.WriteLine("Euclidean Distance = " + distance);
            Console.WriteLine("Equation of Line: y = " + line[0] + "*x + " + line[1]);
        }

        public static double EuclideanDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static double[] LineEquation(double x1, double y1, double x2, double y2)
        {
            double m = (y2 - y1) / (x2 - x1);
            double b = y1 - m * x1;
            return new double[] { m, b };
        }
    }
}
