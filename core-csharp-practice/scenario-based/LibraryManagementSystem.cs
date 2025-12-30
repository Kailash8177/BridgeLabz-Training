using System;
using System.Collections.Generic;
using System.Text;

/*
Summary:
This program is a simple Library Management System built using C#.
It allows an Admin to add, view, and remove books using a password.
Users can view available books, search by title, and checkout books.
Book details such as title, author, and status are stored in a 2D array.
The program uses a menu-driven approach for easy interaction.
*/


namespace BridgeLabzTraining.core_csharp_practice.Scenariobased
{
    internal class LibraryManagementSystem
    {
        // 2D array to store book details
        // [0] -> Title, [1] -> Author, [2] -> Status (Available / Checked Out)
        static string[,] books;

        // Logical count of books
        static int bookCount;

        // Admin password (static because Main is static)
        static string adminPassword = "admin123";

        // -------------------- MAIN METHOD --------------------
        // Entry point of the application
        public static void Main(string[] args)
        {
            LibraryManagementSystem lms = new LibraryManagementSystem();
            int role;

            // Main loop so that program does NOT exit after Admin/User exits
            do
            {
                Console.WriteLine("\n===== Library Management System =====");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. User");
                Console.WriteLine("3. Exit Application");
                Console.Write("Select Role: ");

                role = int.Parse(Console.ReadLine());

                switch (role)
                {
                    case 1: // ---------- ADMIN ----------
                        Console.Write("Enter Admin Password: ");
                        string pass = Console.ReadLine();

                        if (pass == adminPassword)
                        {
                            Console.WriteLine("✅ Admin Login Successful");
                            lms.AdminMenu();   // return here after Admin exit
                        }
                        else
                        {
                            Console.WriteLine("❌ Wrong Password. Access Denied!");
                        }
                        break;

                    case 2: // ---------- USER ----------
                        if (books == null)
                        {
                            Console.WriteLine("❌ No books available. Please contact Admin.");
                        }
                        else
                        {
                            lms.UserMenu();    // return here after User exit
                        }
                        break;

                    case 3: // ---------- EXIT ----------
                        Console.WriteLine("🚪 Exiting Application...");
                        break;

                    default:
                        Console.WriteLine("Invalid Role. Try again.");
                        break;
                }

            } while (role != 3);
        }

        // -------------------- ADMIN MENU --------------------
        // Admin can Add, Display and Remove books
        public void AdminMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Admin Menu ---");
                Console.WriteLine("1. Add Books");
                Console.WriteLine("2. Display Books");
                Console.WriteLine("3. Remove Book");
                Console.WriteLine("4. Exit");

                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: // Add books only once
                        if (books == null)
                        {
                            InitializeBooks();
                            InputOfBook();
                        }
                        else
                        {
                            Console.WriteLine("⚠ Books are already added.");
                        }
                        break;

                    case 2: // Display books
                        DisplayBooks();
                        break;

                    case 3: // Remove book
                        RemoveBook();
                        break;

                    case 4: // Exit Admin Menu
                        Console.WriteLine("Admin Exit...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 4);
        }

        // -------------------- INITIALIZE BOOKS --------------------
        // Admin enters total number of books
        public void InitializeBooks()
        {
            Console.Write("Enter number of books: ");
            bookCount = int.Parse(Console.ReadLine());

            books = new string[bookCount, 3];
        }

        // -------------------- INPUT BOOK DETAILS --------------------
        // Admin enters title and author
        public void InputOfBook()
        {
            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine($"Enter details for Book {i + 1}:");

                Console.Write("Title: ");
                books[i, 0] = Console.ReadLine();

                Console.Write("Author: ");
                books[i, 1] = Console.ReadLine();

                // Initially all books are available
                books[i, 2] = "Available";
            }
        }

        // -------------------- DISPLAY BOOKS --------------------
        public void DisplayBooks()
        {
            Console.WriteLine("\nBooks in Library:");
            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine(
                    $"Title: {books[i, 0]}, Author: {books[i, 1]}, Status: {books[i, 2]}"
                );
            }
        }

        // -------------------- SEARCH BOOK --------------------
        public void SearchBook()
        {
            Console.Write("Enter book title to search: ");
            string key = Console.ReadLine().ToLower();

            bool found = false;

            for (int i = 0; i < bookCount; i++)
            {
                // Partial match allowed
                if (books[i, 0].ToLower().Contains(key))
                {
                    Console.WriteLine(
                        $"Book Found → Title: {books[i, 0]}, Author: {books[i, 1]}, Status: {books[i, 2]}"
                    );
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Book not found in the library.");
            }
        }

        // -------------------- USER MENU --------------------
        // User can only View, Search and Checkout books
        public void UserMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- User Menu ---");
                Console.WriteLine("1. Display Books");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Checkout Book");
                Console.WriteLine("4. Exit");

                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayBooks();
                        break;

                    case 2:
                        SearchBook();
                        break;

                    case 3:
                        CheckoutBook();
                        break;

                    case 4:
                        Console.WriteLine("User Exit...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 4);
        }

        // -------------------- CHECKOUT BOOK --------------------
        public void CheckoutBook()
        {
            Console.Write("Enter book title to checkout: ");
            string key = Console.ReadLine().ToLower();

            bool found = false;

            for (int i = 0; i < bookCount; i++)
            {
                if (books[i, 0].ToLower().Equals(key))
                {
                    if (books[i, 2] == "Available")
                    {
                        books[i, 2] = "Checked Out";
                        Console.WriteLine($"You have successfully checked out '{books[i, 0]}'.");
                    }
                    else
                    {
                        Console.WriteLine($"'{books[i, 0]}' is already checked out.");
                    }

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Book not found in the library.");
            }
        }

        // -------------------- REMOVE BOOK (ADMIN) --------------------
        public void RemoveBook()
        {
            if (books == null || bookCount == 0)
            {
                Console.WriteLine("No books available to remove.");
                return;
            }

            Console.Write("Enter book title to remove: ");
            string key = Console.ReadLine().ToLower();

            bool found = false;

            for (int i = 0; i < bookCount; i++)
            {
                if (books[i, 0].ToLower().Equals(key))
                {
                    // Shift remaining books to fill gap
                    for (int j = i; j < bookCount - 1; j++)
                    {
                        books[j, 0] = books[j + 1, 0];
                        books[j, 1] = books[j + 1, 1];
                        books[j, 2] = books[j + 1, 2];
                    }

                    bookCount--; // reduce logical size
                    found = true;

                    Console.WriteLine("Book removed successfully.");
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
}
