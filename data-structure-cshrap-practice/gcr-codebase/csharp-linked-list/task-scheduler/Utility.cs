using System;
using System.Collections.Generic;
using System.Text;

namespace task_scheduler
{
    /*
 * Main class: Takes user input and controls TaskScheduler
 */
    public class Utility
    {
        public static void Main()
        {
            TaskScheduler scheduler = new TaskScheduler();
            int choice;

            do
            {
                Console.WriteLine("\n--- Task Scheduler ---");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Display Tasks");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Task ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Task Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Priority: ");
                        int priority = Convert.ToInt32(Console.ReadLine());

                        scheduler.AddTask(id, name, priority);
                        Console.WriteLine("Task added successfully");
                        break;

                    case 2:
                        scheduler.DisplayTasks();
                        break;

                    case 3:
                        Console.WriteLine("Exiting Task Scheduler...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 3);
        }
    }
}
