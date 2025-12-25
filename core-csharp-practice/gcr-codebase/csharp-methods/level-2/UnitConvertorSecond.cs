using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_2
{
    public class UnitConvertorSecond
    {
        public static void Main()
        {
            double yards, feet, meters, inches;

            yards = double.Parse(Console.ReadLine());
            Console.WriteLine(yards + " yards = " + ConvertYardsToFeet(yards) + " feet");

            feet = double.Parse(Console.ReadLine());
            Console.WriteLine(feet + " feet = " + ConvertFeetToYards(feet) + " yards");

            meters = double.Parse(Console.ReadLine());
            Console.WriteLine(meters + " meters = " + ConvertMetersToInches(meters) + " inches");

            inches = double.Parse(Console.ReadLine());
            Console.WriteLine(inches + " inches = " + ConvertInchesToMeters(inches) + " meters");
            Console.WriteLine(inches + " inches = " + ConvertInchesToCentimeters(inches) + " cm");
        }

        public static double ConvertYardsToFeet(double yards)
        {
            double yards2feet = 3;
            return yards * yards2feet;
        }

        public static double ConvertFeetToYards(double feet)
        {
            double feet2yards = 0.333333;
            return feet * feet2yards;
        }

        public static double ConvertMetersToInches(double meters)
        {
            double meters2inches = 39.3701;
            return meters * meters2inches;
        }

        public static double ConvertInchesToMeters(double inches)
        {
            double inches2meters = 0.0254;
            return inches * inches2meters;
        }

        public static double ConvertInchesToCentimeters(double inches)
        {
            double inches2cm = 2.54;
            return inches * inches2cm;
        }

    }
}
