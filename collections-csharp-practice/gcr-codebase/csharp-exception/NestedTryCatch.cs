using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    
    internal class NestedTryCatchDemo
    {
        public static void Main()
        {
            int[] values = { 10, 20, 30 };

            try
            {
                try
                {
                    Console.Write("Enter index: ");
                    int index = int.Parse(Console.ReadLine());

                    Console.Write("Enter divisor: ");
                    int divisor = int.Parse(Console.ReadLine());

                    Console.WriteLine(values[index] / divisor);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
    }

}
