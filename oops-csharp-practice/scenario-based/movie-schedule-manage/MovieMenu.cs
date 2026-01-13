using System;
using System.Collections.Generic;
using System.Text;

namespace movie_schedule_manage
{
    class MovieMenu
    {
        private MovieManager manager;

        public MovieMenu()
        {
            DisplayMenu();
        }

        void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("\n Welcome to CinemaTime");
                Console.WriteLine("1 -> Admin");
                Console.WriteLine("2 -> Customer");
                Console.WriteLine("3 -> Exit");
                Console.Write("Choice: ");

                int role = int.Parse(Console.ReadLine());

                switch (role)
                {
                    case 1:
                        RunAdminMenu();
                        break;

                    case 2:
                        RunCustomerMenu();
                        break;

                    case 3:
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        void RunAdminMenu()
        {
            Console.WriteLine("\n Admin Mode");

            while (true)
            {
                Console.WriteLine("\n1. Add Movie");
                Console.WriteLine("2. View Movies");
                Console.WriteLine("3. Exit");
                Console.Write("Choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (manager == null)
                        {
                            Console.Write("Enter number of movies: ");
                            int size = int.Parse(Console.ReadLine());
                            manager = new MovieManager(size);
                        }

                        Console.Write("Enter movie title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter show time (HH:mm): ");
                        string time = Console.ReadLine();

                        manager.AddMovie(title, time);
                        break;

                    case 2:
                        if (manager == null)
                            Console.WriteLine("No movies added yet.");
                        else
                            manager.DisplayMovie();
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        void RunCustomerMenu()
        {
            if (manager == null)
            {
                Console.WriteLine("No movies available. Please contact admin.");
                return;
            }

            Customer customer = new Customer(manager);
            Console.WriteLine("\n Customer Mode");

            while (true)
            {
                Console.WriteLine("\n1. View Movies");
                Console.WriteLine("2. Search Movie");
                Console.WriteLine("3. Exit");
                Console.Write("Choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        customer.DisplayMovie();
                        break;

                    case 2:
                        Console.Write("Enter keyword: ");
                        string keyword = Console.ReadLine();
                        customer.SearchMovie(keyword);
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
     