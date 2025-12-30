using System;
using System.Collections.Generic;
using System.Text;

/*
It takes answers for 10 multiple-choice questions from the student.
The answers are compared with predefined correct answers.
The program displays correct/incorrect results for each question.
Finally, it calculates the percentage and determines pass or fail status.
*/


namespace BridgeLabzTraining.core_csharp_practice.Scenariobased
{
    // This class is responsible for grading a student's quiz
    internal class StudentQuizGrader
    {
        // Static array that stores the correct answers for the quiz
        // These answers are the same for all students
        static string[] coorectAnswer = { "A", "C", "B", "D", "A", "B", "C", "D", "A", "C" };

        // Entry point of the program
        public static void Main(string[] args)
        {
            int choice;

            // Menu-driven program using do-while loop
            do
            {
                Console.WriteLine("\nStudent Quiz Grader");
                Console.WriteLine("1. Grade a Student's Quiz");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");

                // Read user choice
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Array to store student's answers
                        string[] studentAnswer = new string[10];

                        // Creating object of StudentQuizGrader class
                        StudentQuizGrader sqg = new StudentQuizGrader();

                        // Taking input answers from the student
                        sqg.inputTheAnwer(studentAnswer);

                        // Comparing student answers with correct answers
                        bool[] result = sqg.calculateTheResult(studentAnswer);

                        // Displaying the result for each question
                        sqg.displayTheResult(result);

                        // Calculating the percentage of correct answers
                        double percentage = sqg.calculateThePercentage(result);
                        Console.WriteLine("The percentage of the student: " + percentage + "%");

                        // Checking pass or fail condition
                        if (percentage >= 33)
                        {
                            Console.WriteLine("Student has Passed");
                        }
                        else
                        {
                            Console.WriteLine("Student has Failed");
                        }
                        break;

                    case 2:
                        // Exit the program
                        Console.WriteLine("Exiting the program.");
                        break;

                    default:
                        // Handle invalid input
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (choice != 2); // Continue until user chooses Exit
        }

        // Method to take student answers as input
        public void inputTheAnwer(string[] studentAnswer)
        {
            Console.WriteLine("Enter the answers for 10 questions (A/B/C/D):");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Question " + (i + 1) + ": ");

                // Convert input to uppercase for comparison
                studentAnswer[i] = Console.ReadLine().ToUpper();
            }
        }

        // Method to calculate correct and incorrect answers
        public bool[] calculateTheResult(string[] studentAnswer)
        {
            bool[] result = new bool[10];

            for (int i = 0; i < 10; i++)
            {
                // Compare student's answer with correct answer
                if (studentAnswer[i].Equals(coorectAnswer[i]))
                {
                    result[i] = true;   // Correct answer
                }
                else
                {
                    result[i] = false;  // Incorrect answer
                }
            }
            return result;
        }

        // Method to display the result of each question
        public void displayTheResult(bool[] result)
        {
            Console.WriteLine("\nResults:");

            for (int i = 0; i < 10; i++)
            {
                if (result[i])
                {
                    Console.WriteLine("Question " + (i + 1) + ": Correct");
                }
                else
                {
                    Console.WriteLine("Question " + (i + 1) + ": Incorrect");
                }
            }
        }

        // Method to calculate the percentage of correct answers
        public double calculateThePercentage(bool[] result)
        {
            double correctAnswers = 0;

            // Count total correct answers
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i])
                {
                    correctAnswers++;
                }
            }

            // Calculate percentage
            double percentage = (correctAnswers * 100.0) / 10;
            return percentage;
        }
    }
}
