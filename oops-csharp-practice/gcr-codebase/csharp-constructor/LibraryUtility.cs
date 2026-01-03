using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_constructor.level_1
{
    public class LibraryUtility
    {
        public static void Main()
        {
            LibraryBook b = new LibraryBook("C# Basics", "Microsoft", 400);
            b.BorrowBook();
            b.BorrowBook();
        }
    }

    public class LibraryBook
    {
        public string Title;
        public string Author;
        public double Price;
        public bool IsAvailable;

        public LibraryBook(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
            IsAvailable = true;
        }

        public void BorrowBook()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine("Book borrowed successfully");
            }
            else
            {
                Console.WriteLine("Book is not available");
            }
        }
    }

}
