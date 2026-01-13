using System;
using System.Collections.Generic;
using System.Text;

namespace movie_schedule_manage
{
    public class Customer : CinemaBase
    {
        public Customer(MovieManager manager) : base(manager.GetTitles().Length)
        {
            movieTitles = manager.GetTitles();
            showTimes = manager.GetTimes();
            count = manager.GetMovieCount();
        }
        public void DisplayMovie()
        {
            Console.WriteLine("\n Available Movies:");
            if (count == 0)
            {
                Console.WriteLine("No shows available.");
                return;
            }

            Console.WriteLine(" Movie Title          |  Show Time");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(FormatMovie(i));
            }
        }
        public void SearchMovie(string keyword)
        {
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (movieTitles[i].ToLower().Contains(keyword.ToLower()))
                {
                    Console.WriteLine(FormatMovie(i));
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("Movie not found.");
        }
    }
}
