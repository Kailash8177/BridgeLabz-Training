//using System;
//using System.Collections.Generic;
//using System.Text;

///*
// This program demonstrates a menu-driven Mathematical Operations System.
// It allows the user to perform different mathematical calculations such as
// factorial, prime number check, GCD of two numbers, and finding the nth Fibonacci number.
// The program uses methods, loops, and conditional statements for better modularity.
// */

//namespace BridgeLabzTraining.opps_chsarp_pracitce.cenario_based
//{
//    internal class MathematicalOperations
//    {
//        // Entry point of the program
//        public static void Main(string[] args)
//        {
//            // Creating object to call non-static methods
//            MathematicalOperations mo = new MathematicalOperations();

//            int choice;
//            do
//            {
//                // Display menu options
//                Console.WriteLine("\n----Mathematical Operations Menu----");
//                Console.WriteLine("1. Factorial of a Number");
//                Console.WriteLine("2. Prime Number Check");
//                Console.WriteLine("3. GCD of Two Numbers");
//                Console.WriteLine("4. Nth Fibonacci Number");
//                Console.WriteLine("5. Exit the Program\n");
//                Console.Write("Enter your choice (1-5): ");

//                // Reading user choice
//                choice = int.Parse(Console.ReadLine());

//                // Perform operation based on user choice
//                switch (choice)
//                {
//                    case 1:
//                        mo.Fatorial();
//                        break;

//                    case 2:
//                        mo.ChechkPrime();
//                        break;

//                    case 3:
//                        mo.GCD();
//                        break;

//                    case 4:
//                        mo.Fibonacci();
//                        break;

//                    case 5:
//                        Console.WriteLine("Successfully exiting the program.");
//                        break;

//                    default:
//                        Console.WriteLine("Invalid choice. Please select a valid operation.");
//                        break;
//                }
//            }
//            // Loop continues until user selects Exit option
//            while (choice != 5);
//        }

//        // Method to calculate factorial of a number
//        public void Fatorial()
//        {
//            Console.WriteLine("Enter the number:");
//            int number = int.Parse(Console.ReadLine());

//            // Factorial is not defined for negative numbers
//            if (number < 0)
//            {
//                Console.WriteLine("Please enter a valid non-negative number.");
//            }
//            else
//            {
//                int fact = 1;

//                // Loop to calculate factorial
//                for (int i = 1; i <= number; i++)
//                {
//                    fact = fact * i;
//                }

//                Console.WriteLine($"Factorial of {number} is: {fact}");
//            }
//        }

//        // Method to check whether a number is prime or not
//        public void ChechkPrime()
//        {
//            Console.WriteLine("Enter the number:");
//            int number = int.Parse(Console.ReadLine());

//            bool isPrime = true;

//            // Numbers less than or equal to 1 are not prime
//            if (number <= 1)
//            {
//                isPrime = false;
//            }
//            else
//            {
//                // Check divisibility up to square root of number
//                for (int i = 2; i <= Math.Sqrt(number); i++)
//                {
//                    if (number % i == 0)
//                    {
//                        isPrime = false;
//                        break;
//                    }
//                }
//            }

//            // Display result
//            if (isPrime)
//            {
//                Console.WriteLine($"{number} is a prime number.");
//            }
//            else
//            {
//                Console.WriteLine($"{number} is not a prime number.");
//            }
//        }

//        // Method to find GCD of two numbers using Euclidean Algorithm
//        public void GCD()
//        {
//            Console.WriteLine("Enter the first number:");
//            int num1 = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter the second number:");
//            int num2 = int.Parse(Console.ReadLine());

//            // GCD is not defined for negative numbers
//            if (num1 < 0 || num2 < 0)
//            {
//                Console.WriteLine("Please enter valid non-negative numbers.");
//            }
//            else
//            {
//                // Euclidean Algorithm to calculate GCD
//                while (num2 != 0)
//                {
//                    int temp = num2;
//                    num2 = num1 % num2;
//                    num1 = temp;
//                }

//                Console.WriteLine($"GCD is: {num1}");
//            }
//        }

//        // Method to find the nth Fibonacci number
//        public void Fibonacci()
//        {
//            Console.WriteLine("Enter the position of Fibonacci number to find:");
//            int n = int.Parse(Console.ReadLine());

//            // Fibonacci is defined for positive integers
//            if (n <= 0)
//            {
//                Console.WriteLine("Please enter a positive integer.");
//                return;
//            }

//            int a = 0, b = 1, fib = 0;

//            // Handle base cases
//            if (n == 1)
//            {
//                fib = a;
//            }
//            else if (n == 2)
//            {
//                fib = b;
//            }
//            else
//            {
//                // Loop to calculate nth Fibonacci number
//                for (int i = 3; i <= n; i++)
//                {
//                    fib = a + b;
//                    a = b;
//                    b = fib;
//                }
//            }

//            Console.WriteLine($"The {n}th Fibonacci number is: {fib}");
//        }
//    }
//}
