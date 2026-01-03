using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_constructor.level_1
{
    public class BookUtilityTwo
    {
        public static void Main()
        {
            Book b = new Book("ISBN-101", "C# Basics", "Microsoft");
            b.Display();
            Console.WriteLine("Author: " + b.GetAuthor());
        }
    }
    public class Book
    {
        public string ISBN;        // public
        protected string Title;    // protected
        private string Author;     // private

        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        public void SetAuthor(string author)
        {
            Author = author;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public void Display()
        {
            Console.WriteLine($"ISBN: {ISBN}, Title: {Title}");
        }
    }
}
