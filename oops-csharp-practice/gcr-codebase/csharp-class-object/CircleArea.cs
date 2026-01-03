using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_class_object.level_1
{
    public class CircleArea
    {
        public static void Main()
        {
            Circle c = new Circle();

            c.radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Radius          : " + c.radius);
            Console.WriteLine("Area            : " + c.CalculateArea());
            Console.WriteLine("Circumference   : " + c.CalculateCircumference());
        }
    }
    public class Circle
    {
        public double radius;
        // Method to calculate area of the circle
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        // Method to calculate circumference of the circle
        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }
    }
}
