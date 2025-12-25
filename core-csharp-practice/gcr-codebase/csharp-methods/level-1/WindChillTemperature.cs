using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    public class WindChillTemperature
    {
        public static void Main()
        {
            double temp, windSpeed;
            double windChill;

            temp = double.Parse(Console.ReadLine());
            windSpeed = double.Parse(Console.ReadLine());

            windChill = CalculateWindChill(temp, windSpeed);

            Console.WriteLine("Wind Chill Temperature = " + windChill);
        }
        public static double CalculateWindChill(double temp, double windSpeed)
        {
            double windChill = 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * Math.Pow(windSpeed, 0.16);
            return windChill;
        }

    }
}
