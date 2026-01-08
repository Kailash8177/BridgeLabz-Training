using System;
using System.Collections.Generic;
using System.Text;

namespace round_robin_scheduling
{
    /*
  * Main class: Takes user input and controls process scheduling
  */
    class Program
    {
        public static void Main()
        {
            ProcessScheduler scheduler = new ProcessScheduler();
            int choice;

            do
            {
                Console.WriteLine("\n--- CPU Process Scheduler ---");
                Console.WriteLine("1. Add Process");
                Console.WriteLine("2. Display Processes");
                Console.WriteLine("3. Execute Round Robin");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Process ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Burst Time: ");
                        int burst = Convert.ToInt32(Console.ReadLine());

                        scheduler.AddProcess(id, burst);
                        Console.WriteLine("Process added successfully");
                        break;

                    case 2:
                        scheduler.DisplayProcesses();
                        break;

                    case 3:
                        Console.Write("Enter Time Quantum: ");
                        int tq = Convert.ToInt32(Console.ReadLine());

                        scheduler.ExecuteRoundRobin(tq);
                        break;

                    case 4:
                        Console.WriteLine("Exiting Scheduler...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 4);
        }

    }
}
