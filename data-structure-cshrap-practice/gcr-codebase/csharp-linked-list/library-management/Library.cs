using System;
using System.Collections.Generic;
using System.Text;

namespace library_management
{

    /*
     * Library class manages books using a Doubly Linked List.
     */
    class Library
    {
        private BookNode head; // Points to first book

        // Add book at the end of the list
        public void AddBook(BookNode book)
        {
            // If list is empty
            if (head == null)
            {
                head = book;
                return;
            }

            // Traverse to last node
            BookNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            // Link new book
            temp.Next = book;
            book.Prev = temp;
        }

        // Count total number of books
        public int CountBooks()
        {
            int count = 0;
            BookNode temp = head;

            // Traverse list and count nodes
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }

            return count;
        }

        // Display all books
        public void DisplayBooks()
        {
            if (head == null)
            {
                Console.WriteLine("Library is empty");
                return;
            }

            BookNode temp = head;
            Console.WriteLine("\nLibrary Books:");
            while (temp != null)
            {
                Console.WriteLine(
                    $"ID: {temp.BookId}, Title: {temp.Title}, Author: {temp.Author}, Available: {temp.Available}"
                );
                temp = temp.Next;
            }
        }
    }
}
