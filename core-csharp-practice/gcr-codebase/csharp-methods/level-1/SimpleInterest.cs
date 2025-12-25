using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    public class SimpleInterest
    {

        public static void Main()
        {
            double principal, rate, time;
            double simpleInterest;

            principal = double.Parse(Console.ReadLine());
            rate = double.Parse(Console.ReadLine());
            time = double.Parse(Console.ReadLine());

            simpleInterest = CalculateSimpleInterest(principal, rate, time);

            Console.WriteLine("The Simple Interest is " + simpleInterest + " for Principal " + principal + ", Rate of Interest " + rate + " and Time " + time);
        }
        public static double CalculateSimpleInterest(double principal, double rate, double time)
        {
            double si = (principal * rate * time) / 100;
            return si;
        }

    }
}
