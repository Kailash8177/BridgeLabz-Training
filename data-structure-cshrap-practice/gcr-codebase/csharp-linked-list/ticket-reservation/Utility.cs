using System;
using System.Collections.Generic;
using System.Text;

namespace ticket_reservation
{
    /*
 * Main class: Takes user input and controls TicketSystem
 */
    class Utility
    {
        public static void Main()
        {
            TicketSystem system = new TicketSystem();
            int choice;

            do
            {
                Console.WriteLine("\n--- Ticket Management System ---");
                Console.WriteLine("1. Add Ticket");
                Console.WriteLine("2. Display Tickets");
                Console.WriteLine("3. Count Tickets");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Ticket ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Customer Name: ");
                        string cust = Console.ReadLine();

                        system.AddTicket(id, cust);
                        Console.WriteLine("Ticket added successfully");
                        break;

                    case 2:
                        system.DisplayTickets();
                        break;

                    case 3:
                        Console.WriteLine($"Total Tickets = {system.CountTickets()}");
                        break;

                    case 4:
                        Console.WriteLine("Exiting Ticket System...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 4);
        }
    }

}
