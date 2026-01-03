using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_constructor.level_1
{
    public class BookUtility
    {
        public static void Main()
        {
            Book b1 = new Book();
            Book b2 = new Book("Clean Code", "Robert Martin", 550);

            b1.Display();
            b2.Display();
        }
    }
    public class Book
    {
        public string Title;
        public string Author;
        public double Price;

        // Default constructor
        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
            Price = 0.0;
        }

        // Parameterized constructor
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine($"{Title} | {Author} | ₹{Price}");
        }
    }
}
