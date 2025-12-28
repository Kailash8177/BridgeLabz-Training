using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_builtin.level_2
{
    public class TemperatureConverter
    {
        public static void Main()
        {
            double temp = double.Parse(Console.ReadLine());
            Console.WriteLine("C to F: " + CelsiusToFahrenheit(temp));
            Console.WriteLine("F to C: " + FahrenheitToCelsius(temp));
        }
        public static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double f)
        {
            return (f - 32) * 5 / 9;
        }
    }
}
