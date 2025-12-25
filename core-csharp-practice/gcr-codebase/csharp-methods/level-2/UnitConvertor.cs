using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_2
{
    public class UnitConvertor
    {
        public static void Main()
        {
            double km, miles, meters, feet;

            km = double.Parse(Console.ReadLine());
            Console.WriteLine(km + " km = " + ConvertKmToMiles(km) + " miles");

            miles = double.Parse(Console.ReadLine());
            Console.WriteLine(miles + " miles = " + ConvertMilesToKm(miles) + " km");

            meters = double.Parse(Console.ReadLine());
            Console.WriteLine(meters + " meters = " + ConvertMetersToFeet(meters) + " feet");

            feet = double.Parse(Console.ReadLine());
            Console.WriteLine(feet + " feet = " + ConvertFeetToMeters(feet) + " meters");
        }

        public static double ConvertKmToMiles(double km)
        {
            double km2miles = 0.621371;
            return km * km2miles;
        }

        public static double ConvertMilesToKm(double miles)
        {
            double miles2km = 1.60934;
            return miles * miles2km;
        }

        public static double ConvertMetersToFeet(double meters)
        {
            double meters2feet = 3.28084;
            return meters * meters2feet;
        }

        public static double ConvertFeetToMeters(double feet)
        {
            double feet2meters = 0.3048;
            return feet * feet2meters;
        }
    }
}
