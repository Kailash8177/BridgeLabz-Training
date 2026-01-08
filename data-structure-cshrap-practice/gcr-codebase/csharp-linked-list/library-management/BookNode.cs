using System;
using System.Collections.Generic;
using System.Text;

namespace library_management
{

    /*
     * BookNode represents a single book in the library.
     * Each node stores book details and links to previous and next books.
     */
    class BookNode
    {
        public int BookId;
        public string Title, Author;
        public bool Available;
        public BookNode Prev, Next;

        // Constructor to initialize book details
        public BookNode(int id, string t, string a)
        {
            BookId = id;
            Title = t;
            Author = a;
            Available = true;   // Book is available by default
            Prev = null;
            Next = null;
        }
    }
}
