using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{

    
    internal class ExceptionPropagationDemo
    {
        static void Method1()
        {
            int denominator = 0;
            int x = 10 / denominator;
        }

        static void Method2()
        {
            Method1();
        }

        public static void Main()
        {
            try
            {
                Method2();
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Handled exception in Main");
            }
        }
    }

}
