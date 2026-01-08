using System;
using System.Collections.Generic;
using System.Text;

namespace library_management
{
    /*
 * Main class: Takes user input and interacts with Library
 */
    class Program
    {
        public static void Main()
        {
            Library library = new Library();
            int choice;

            do
            {
                Console.WriteLine("\n--- Library Management System ---");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Display Books");
                Console.WriteLine("3. Count Total Books");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Book ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();

                        BookNode book = new BookNode(id, title, author);
                        library.AddBook(book);

                        Console.WriteLine("Book added successfully");
                        break;

                    case 2:
                        library.DisplayBooks();
                        break;

                    case 3:
                        Console.WriteLine($"Total Books = {library.CountBooks()}");
                        break;

                    case 4:
                        Console.WriteLine("Exiting Library System...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 4);
        }
    }
}
