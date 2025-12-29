//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BridgeLabzTraining.core_csharp_practice.Scenariobased
//{
//    public class StudentScore
//    {
//        // Entry point of the program
//        public static void Main()
//        {
//            // Creating object to call non-static methods
//            StudentScore obj = new StudentScore();

//            char repeat;   // Variable to control repetition of whole program

//            // Outer loop: repeats the entire process until user chooses to exit
//            do
//            {
//                // ---------------- INPUT SECTION ----------------

//                // Taking number of students
//                Console.Write("\nEnter number of students: ");
//                int n = int.Parse(Console.ReadLine());

//                // Array to store scores of students
//                int[] scores = new int[n];

//                // Loop to take score input for each student
//                for (int i = 0; i < n; i++)
//                {
//                    Console.Write("Enter score of student " + (i + 1) + ": ");
//                    int score = int.Parse(Console.ReadLine());

//                    // Validation: score cannot be negative
//                    if (score < 0)
//                    {
//                        Console.WriteLine("Invalid score. Enter again.");
//                        i--; // Decrement index to re-enter score for same student
//                    }
//                    else
//                    {
//                        scores[i] = score; // Store valid score in array
//                    }
//                }

//                // ---------------- CALCULATION SECTION ----------------

//                // Finding maximum score using method
//                int max = obj.FindMax(scores);

//                // Finding minimum score using method
//                int min = obj.FindMin(scores);

//                // Calculating average score
//                // Casting is done before division to avoid integer division
//                double average = (double)obj.CalculateSum(scores) / n;

//                int choice;

//                // Inner loop: menu keeps running until user exits menu
//                do
//                {
//                    // ---------------- MENU SECTION ----------------
//                    Console.WriteLine("\n===== MENU =====");
//                    Console.WriteLine("1. Show Average");
//                    Console.WriteLine("2. Show Highest");
//                    Console.WriteLine("3. Show Lowest");
//                    Console.WriteLine("4. Show Scores Above Average");
//                    Console.WriteLine("5. Exit Menu");

//                    Console.Write("Enter choice: ");
//                    choice = int.Parse(Console.ReadLine());

//                    // Switch-case to handle user choice
//                    switch (choice)
//                    {
//                        case 1:
//                            // Display average score
//                            Console.WriteLine("Average Score: " + average);
//                            break;

//                        case 2:
//                            // Display highest score
//                            Console.WriteLine("Highest Score: " + max);
//                            break;

//                        case 3:
//                            // Display lowest score
//                            Console.WriteLine("Lowest Score: " + min);
//                            break;

//                        case 4:
//                            // Display scores that are above average
//                            Console.WriteLine("Scores Above Average:");
//                            for (int i = 0; i < n; i++)
//                            {
//                                if (scores[i] > average)
//                                {
//                                    Console.WriteLine(scores[i]);
//                                }
//                            }
//                            break;

//                        case 5:
//                            // Exit from menu
//                            Console.WriteLine("Exiting menu...");
//                            break;

//                        default:
//                            // Invalid menu choice
//                            Console.WriteLine("Invalid choice.");
//                            break;
//                    }

//                } while (choice != 5);

//                // Asking user if they want to repeat the entire process
//                Console.Write("\nDo you want to enter scores again? (y/n): ");
//                repeat = Console.ReadLine()[0]; // Taking first character of input

//            } while (repeat == 'y' || repeat == 'Y');

//            // Program termination message
//            Console.WriteLine("\nProgram Ended. Thank you!");
//        }

//        // Method to find the maximum value in the array
//        public int FindMax(int[] arr)
//        {
//            int max = arr[0];

//            for (int i = 1; i < arr.Length; i++)
//            {
//                if (arr[i] > max)
//                {
//                    max = arr[i];
//                }
//            }
//            return max;
//        }

//        // Method to find the minimum value in the array
//        public int FindMin(int[] arr)
//        {
//            int min = arr[0];

//            for (int i = 1; i < arr.Length; i++)
//            {
//                if (arr[i] < min)
//                {
//                    min = arr[i];
//                }
//            }
//            return min;
//        }

//        // Method to calculate the sum of all elements in the array
//        public int CalculateSum(int[] arr)
//        {
//            int sum = 0;

//            for (int i = 0; i < arr.Length; i++)
//            {
//                sum += arr[i];
//            }
//            return sum;
//        }
//    }
//}