using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    
    internal class DivisionCalculator
    {
        public static void Main()
        {
            try
            {
                Console.Write("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Result: " + (num1 / num2));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter numeric values only");
            }
        }
    }

}
