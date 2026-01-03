using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_class_object.level_1
{
    public class Book
    {
        public static void Main()
        {
            BookDetails book = new BookDetails();

            // Assigning values
            Console.WriteLine("Enter Book Title :");
            book.title = Console.ReadLine();

            Console.WriteLine("Enter Book Author :");

            book.author = Console.ReadLine();

            Console.WriteLine("Enter the price");
            book.price = int.Parse(Console.ReadLine());

            // Displaying details
            book.ShowBookDetails();
        }
    }
    class BookDetails
    {
        // Fields
        public string title;
        public string author;
        public double price;

        // Method to display book details
        public void ShowBookDetails()
        {
            Console.WriteLine("Book Title  : " + title);
            Console.WriteLine("Author      : " + author);
            Console.WriteLine("Price       : " + price);
        }
    }
}
