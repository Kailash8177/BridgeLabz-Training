using System;
using System.Collections.Generic;
using System.Text;

namespace digital_bookshelf_app
{
    internal class Utility
    {
        public static void Main() 
        {
            Console.Write("Enter number of books you want to store: ");
            int size = int.Parse(Console.ReadLine());

            // Polymorphism via Interface
            IBook shelf = new Book(size);

            int choice;

            do
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Display Books");
                Console.WriteLine("3. Sort Books Alphabetically");
                Console.WriteLine("4. Search By Author");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter book title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter author name: ");
                        string author = Console.ReadLine();

                        shelf.AddBook(title, author);
                        break;

                    case 2:
                        Console.WriteLine("\n--- All Books ---");
                        shelf.DisplayBooks();
                        break;

                    case 3:
                        shelf.SortBooksAlphabetically();
                        break;

                    case 4:
                        Console.Write("Enter author to search: ");
                        string searchAuthor = Console.ReadLine();
                        shelf.SearchByAuthor(searchAuthor);
                        break;

                    case 5:
                        Console.WriteLine("Exiting BookBuddy. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != 5);
        }
    }
}
