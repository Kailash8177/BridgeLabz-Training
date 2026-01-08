using System;
using System.Collections.Generic;
using System.Text;

namespace movie_management_system
{
    class MovieNode
    {
        public string Title, Director;
        public int Year;
        public double Rating;
        public MovieNode Prev, Next;

        // Constructor to initialize movie details
        public MovieNode(string t, string d, int y, double r)
        {
            Title = t;
            Director = d;
            Year = y;
            Rating = r;
            Prev = null;
            Next = null;
        }
    }
}
