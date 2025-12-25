using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    public class TrigonometricFunctions
    {

        public static void Main()
        {
            double angle;
            double[] result;

            angle = double.Parse(Console.ReadLine());

            result = CalculateTrigonometricFunctions(angle);

            Console.WriteLine("Sine = " + result[0]);
            Console.WriteLine("Cosine = " + result[1]);
            Console.WriteLine("Tangent = " + result[2]);
        }
        public static double[] CalculateTrigonometricFunctions(double angle)
        {
            double radians = angle * Math.PI / 180;
            double sine = Math.Sin(radians);
            double cosine = Math.Cos(radians);
            double tangent = Math.Tan(radians);

            double[] result = new double[3];
            result[0] = sine;
            result[1] = cosine;
            result[2] = tangent;
            return result;
        }
    }
}
