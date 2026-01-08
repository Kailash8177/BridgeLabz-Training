using System;
using System.Collections.Generic;
using System.Text;

namespace movie_management_system
{

    /*
     * MovieList manages all movie nodes using a doubly linked list.
     */
    class MovieList
    {
        private MovieNode head; // Points to the first movie

        // Add movie at the end of the list
        public void AddMovie(string t, string d, int y, double r)
        {
            MovieNode node = new MovieNode(t, d, y, r);

            // If list is empty
            if (head == null)
            {
                head = node;
                return;
            }

            // Traverse to last node
            MovieNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            // Link new node
            temp.Next = node;
            node.Prev = temp;
        }

        // Remove movie by title
        public void RemoveByTitle(string title)
        {
            MovieNode temp = head;

            // Search movie
            while (temp != null && temp.Title != title)
            {
                temp = temp.Next;
            }

            // If movie not found
            if (temp == null)
            {
                Console.WriteLine("Movie not found");
                return;
            }

            // If deleting head node
            if (temp.Prev != null)
                temp.Prev.Next = temp.Next;
            else
                head = temp.Next;

            // Update backward link
            if (temp.Next != null)
                temp.Next.Prev = temp.Prev;

            Console.WriteLine("Movie removed successfully");
        }

        // Display movies from start to end
        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("No movies available");
                return;
            }

            MovieNode temp = head;
            Console.WriteLine("\nMovies (Forward):");
            while (temp != null)
            {
                Console.WriteLine($"{temp.Title} | {temp.Director} | {temp.Year} | Rating: {temp.Rating}");
                temp = temp.Next;
            }
        }

        // Display movies from end to start
        public void DisplayReverse()
        {
            if (head == null)
            {
                Console.WriteLine("No movies available");
                return;
            }

            // Move to last node
            MovieNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            Console.WriteLine("\nMovies (Reverse):");
            while (temp != null)
            {
                Console.WriteLine($"{temp.Title} | {temp.Director} | {temp.Year} | Rating: {temp.Rating}");
                temp = temp.Prev;
            }
        }
    }
}
