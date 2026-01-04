using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_obejct_oriented_design.object_modeling
{
    class Book
    {
        public string Title;
        public string Author;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }

    // ---------------- Library ----------------
    class Library
    {
        public string LibraryName;

        // Aggregation using array
        private Book[] books = new Book[5];
        private int count = 0;

        public Library(string name)
        {
            LibraryName = name;
        }

        public void AddBook(Book book)
        {
            if (count < books.Length)
            {
                books[count++] = book;
            }
        }

        public void DisplayBooks()
        {
            Console.WriteLine($"Books in {LibraryName}:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{books[i].Title} by {books[i].Author}");
            }
        }
    }

    // ---------------- Utility ----------------
    class LibraryUtility
    {
        public static void Main()
        {
            Book b1 = new Book("Clean Code", "Robert Martin");
            Book b2 = new Book("OOP", "Grady Booch");

            Library lib = new Library("City Library");
            lib.AddBook(b1);
            lib.AddBook(b2);

            lib.DisplayBooks();
        }
    }
}
