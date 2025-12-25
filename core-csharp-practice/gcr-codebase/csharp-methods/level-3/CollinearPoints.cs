using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_3
{
    public class CollinearPoints
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            bool collinearSlope = AreCollinearSlope(x1, y1, x2, y2, x3, y3);
            bool collinearArea = AreCollinearArea(x1, y1, x2, y2, x3, y3);

            Console.WriteLine("Collinear by slope = " + collinearSlope);
            Console.WriteLine("Collinear by area = " + collinearArea);
        }

        public static bool AreCollinearSlope(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double m1 = (y2 - y1) / (x2 - x1);
            double m2 = (y3 - y2) / (x3 - x2);
            double m3 = (y3 - y1) / (x3 - x1);
            return m1 == m2 && m2 == m3;
        }

        public static bool AreCollinearArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
            return area == 0;
        }
    }
}
