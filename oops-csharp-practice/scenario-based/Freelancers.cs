//using System;
//using System.Collections.Generic;
//using System.Text;


///*
// This program is a Freelancers Management System that processes invoice details entered by the user.
// It accepts multiple freelance tasks with their respective charges in INR.
// The program splits the invoice data, displays individual task details,
// and calculates the total invoice amount using string manipulation techniques.

// */
//namespace BridgeLabzTraining.opps_chsarp_pracitce.cenario_based
//{
//    internal class Freelancers
//    {
//        // Entry point of the program
//        public static void Main(string[] args)
//        {
//            // Welcome message and input format
//            Console.WriteLine("Welcome to the Freelancers Management System! Enter invoice details :");
//            Console.WriteLine("Example: Logo Design - 3000 INR, Web Page - 4500 INR");

//            // Taking invoice input from user
//            string input = Console.ReadLine();

//            // Splitting invoice into individual tasks
//            string[] tasks = ParseInvoice(input);

//            // Displaying invoice details
//            Console.WriteLine("\nInvoice Details:");
//            foreach (string task in tasks)
//            {
//                // Trim is used to remove extra spaces
//                Console.WriteLine(task.Trim());
//            }

//            // Calculating total invoice amount
//            int totalAmount = GetTotalAmount(tasks);

//            // Displaying total amount
//            Console.WriteLine("\nTotal Invoice Amount: " + totalAmount + " INR");
//        }

//        // Method to split the invoice string into tasks
//        // Example:
//        // "Logo Design - 3000 INR, Web Page - 4500 INR"
//        // will be split using comma (,)
//        public static string[] ParseInvoice(string input)
//        {
//            // Split invoice by comma
//            string[] tasks = input.Split(',');
//            return tasks;
//        }

//        // Method to calculate total amount from all tasks
//        public static int GetTotalAmount(string[] tasks)
//        {
//            int total = 0;

//            // Loop through each task
//            foreach (string task in tasks)
//            {
//                // Split task using '-' to separate work name and amount
//                // Example: "Logo Design - 3000 INR"
//                string[] parts = task.Split('-');

//                // Remove "INR" text and extra spaces
//                string amountPart = parts[1].Replace("INR", "").Trim();

//                // Convert string amount to integer
//                int amount = int.Parse(amountPart);

//                // Add amount to total
//                total += amount;
//            }

//            // Return total invoice amount
//            return total;
//        }
//    }
//}
