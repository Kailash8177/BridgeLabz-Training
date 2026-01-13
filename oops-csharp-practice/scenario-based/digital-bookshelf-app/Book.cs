using System;
using System.Collections.Generic;
using System.Text;

namespace digital_bookshelf_app
{
    public class Book : IBook   
    {
        private string[] books;
        private int count;

        public Book(int n)
        {
            books = new string[n];
            count = 0;
        }

        private bool IsValidInput(string title, string author)
        {
            return !string.IsNullOrEmpty(title) &&
                   !string.IsNullOrEmpty(author);
        }

        private string[] SplitBook(string book)
        {
            return book.Split(" - ");
        }

        public bool AddBook(string title, string author)
        {
            if (count >= books.Length)
            {
                Console.WriteLine("Bookshelf is full.");
                return false;
            }

            if (!IsValidInput(title, author))
            {
                Console.WriteLine("Invalid book format.");
                return false;
            }

            books[count] = $"{title} - {author}";
            count++;
            Console.WriteLine("Book added successfully.");
            return true;
        }

        public void SortBooksAlphabetically()
        {
            if (count == 0)
            {
                Console.WriteLine("No books to sort.");
                return;
            }

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (string.Compare(books[i], books[j], true) > 0)
                    {
                        string temp = books[i];
                        books[i] = books[j];
                        books[j] = temp;
                    }
                }
            }

            Console.WriteLine("Books sorted alphabetically.");
        }

        public void SearchByAuthor(string author)
        {
            if (count == 0)
            {
                Console.WriteLine("Bookshelf is empty.");
                return;
            }

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                string[] parts = SplitBook(books[i]);

                if (parts.Length == 2 &&
                    parts[1].Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(books[i]);
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No books found for author: " + author);
        }

        public void DisplayBooks()
        {
            if (count == 0)
            {
                Console.WriteLine("Bookshelf is empty.");
                return;
            }

            for (int i = 0; i < count; i++)
                Console.WriteLine(books[i]);
        }
    }
}
