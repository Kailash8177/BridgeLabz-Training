using System;
using System.Collections.Generic;
using System.Text;

namespace steps_fitness_tracker
{
    internal class FitnessMenu
    {
        public FitnessMenu()
        {
            Menu();
        }

        public void Menu()
        {
            IFitnessOperations fitness = new FitnessUtility();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Fitness Tracker Menu ---");
                Console.WriteLine("1. Add User Steps");
                Console.WriteLine("2. Display Ranking");
                Console.WriteLine("3. Sort by Steps");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter User Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Steps: ");
                        int steps = Convert.ToInt32(Console.ReadLine());

                        fitness.AddUser(name, steps);
                        Console.WriteLine("User added successfully!");
                        break;

                    case 2:
                        fitness.DisplayRanking();
                        break;

                    case 3:
                        fitness.SortBySteps();
                        Console.WriteLine("Leaderboard updated (Highest steps first).");
                        break;

                    case 4:
                        exit = true;
                        Console.WriteLine("Exiting Fitness Tracker...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}
