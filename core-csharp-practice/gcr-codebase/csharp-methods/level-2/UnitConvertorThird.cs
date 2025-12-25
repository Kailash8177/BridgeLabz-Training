using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_2
{
    public class UnitConvertorThird
    {
        public static void Main()
        {
            double fahrenheit, celsius, pounds, kilograms, gallons, liters;

            fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine(fahrenheit + " °F = " + ConvertFahrenheitToCelsius(fahrenheit) + " °C");

            celsius = double.Parse(Console.ReadLine());
            Console.WriteLine(celsius + " °C = " + ConvertCelsiusToFahrenheit(celsius) + " °F");

            pounds = double.Parse(Console.ReadLine());
            Console.WriteLine(pounds + " pounds = " + ConvertPoundsToKilograms(pounds) + " kg");

            kilograms = double.Parse(Console.ReadLine());
            Console.WriteLine(kilograms + " kg = " + ConvertKilogramsToPounds(kilograms) + " pounds");

            gallons = double.Parse(Console.ReadLine());
            Console.WriteLine(gallons + " gallons = " + ConvertGallonsToLiters(gallons) + " liters");

            liters = double.Parse(Console.ReadLine());
            Console.WriteLine(liters + " liters = " + ConvertLitersToGallons(liters) + " gallons");
        }

        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double ConvertPoundsToKilograms(double pounds)
        {
            return pounds * 0.453592;
        }

        public static double ConvertKilogramsToPounds(double kilograms)
        {
            return kilograms * 2.20462;
        }

        public static double ConvertGallonsToLiters(double gallons)
        {
            return gallons * 3.78541;
        }

        public static double ConvertLitersToGallons(double liters)
        {
            return liters * 0.264172;
        }
    }
}
