using System;
using System.Collections.Generic;
using System.Text;

namespace movie_management_system
{
    /*
    * Main class: Takes user input and performs operations on MovieList
    */
    class Utility
    {
        public static void Main()
        {
            MovieList movies = new MovieList();
            int choice;

            do
            {
                Console.WriteLine("\n--- Movie Management System ---");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Remove Movie by Title");
                Console.WriteLine("3. Display Movies (Forward)");
                Console.WriteLine("4. Display Movies (Reverse)");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Director: ");
                        string director = Console.ReadLine();

                        Console.Write("Enter Release Year: ");
                        int year = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Rating: ");
                        double rating = Convert.ToDouble(Console.ReadLine());

                        movies.AddMovie(title, director, year, rating);
                        Console.WriteLine("Movie added successfully");
                        break;

                    case 2:
                        Console.Write("Enter movie title to remove: ");
                        string removeTitle = Console.ReadLine();
                        movies.RemoveByTitle(removeTitle);
                        break;

                    case 3:
                        movies.DisplayForward();
                        break;

                    case 4:
                        movies.DisplayReverse();
                        break;

                    case 5:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 5);
        }
    }
}
