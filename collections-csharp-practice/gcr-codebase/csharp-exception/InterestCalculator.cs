using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    
    internal class InterestCalculator
    {
        static double CalculateInterest(double amount, double rate, int years)
        {
            if (amount < 0 || rate < 0)
                throw new ArgumentException("Invalid input");

            return amount * rate * years / 100;
        }

        public static void Main()
        {
            try
            {
                double interest = CalculateInterest(1000, -5, 2);
                Console.WriteLine("Interest: " + interest);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid input: Amount and rate must be positive");
            }
        }
    }

}
