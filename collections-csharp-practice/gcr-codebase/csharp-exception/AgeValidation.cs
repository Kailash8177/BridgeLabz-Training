using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
   
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    internal class AgeValidationDemo
    {
        static void ValidateAge(int age)
        {
            if (age < 18)
                throw new InvalidAgeException("Age must be 18 or above");
        }

        public static void Main()
        {
            try
            {
                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());

                ValidateAge(age);
                Console.WriteLine("Access granted!");
            }
            catch (InvalidAgeException)
            {
                Console.WriteLine("Age must be 18 or above");
            }
        }
    }


}
