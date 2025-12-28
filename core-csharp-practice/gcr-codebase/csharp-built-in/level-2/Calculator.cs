using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_builtin.level_2
{
    public class Calculator
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            char op = Console.ReadLine()[0];

            switch (op)
            {
                case '+': Console.WriteLine(Add(a, b)); break;
                case '-': Console.WriteLine(Sub(a, b)); break;
                case '*': Console.WriteLine(Mul(a, b)); break;
                case '/': Console.WriteLine(Div(a, b)); break;
                default: Console.WriteLine("Invalid Operator"); break;
            }

        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }

    }
}
