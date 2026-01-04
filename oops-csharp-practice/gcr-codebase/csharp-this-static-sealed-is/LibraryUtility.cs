using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_this_static_sealed_is
{
    public class LibraryUtility
    {
        public static void Main()
        {
            object b = new Book("C# Guide", "Microsoft", "ISBN101");

            if (b is Book)
            {
                ((Book)b).Display();
            }

            Book.DisplayLibraryName();
        }
    }
    public class Book
    {
        public static string LibraryName = "Central Library";

        public readonly string ISBN;
        public string Title;
        public string Author;

        public Book(string title, string author, string isbn)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
        }

        public static void DisplayLibraryName()
        {
            Console.WriteLine("Library: " + LibraryName);
        }

        public void Display()
        {
            Console.WriteLine($"{Title} | {Author} | {ISBN}");
        }
    }

}
