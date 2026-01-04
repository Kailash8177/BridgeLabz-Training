using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_inheritance
{
    // ---------------- Parent Class ----------------
    class Book
    {
        public string Title;
        public int PublicationYear;

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Year: {PublicationYear}");
        }
    }

    // ---------------- Child Class ----------------
    class Author : Book
    {
        public string Name;
        public string Bio;

        public override void DisplayInfo()
        {
            Console.WriteLine(
                $"Title: {Title}, Year: {PublicationYear}, Author: {Name}, Bio: {Bio}"
            );
        }
    }

    // ---------------- Main Class ----------------
    class LibraryUtility
    {
        public static void Main()
        {
            // Creating Author object (Single Inheritance)
            Author book = new Author
            {
                Title = "OOP Concepts",
                PublicationYear = 2024,
                Name = "Robert Martin",
                Bio = "Software Engineer & Author"
            };

            book.DisplayInfo();
        }
    }
}
