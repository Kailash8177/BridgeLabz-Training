using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_constructor.level_1
{
    public class CircleUtility
    {
        static void Main()
        {
            Circle c1 = new Circle();
            Circle c2 = new Circle(5);

            Console.WriteLine("Area: " + c1.Area());
            Console.WriteLine("Area: " + c2.Area());
        }
    }
    public class Circle
    {
        public double Radius;

        // Default constructor
        public Circle() : this(1.0)   // constructor chaining
        {
        }

        // Parameterized constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

}
