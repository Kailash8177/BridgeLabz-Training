using System;
using System.Collections.Generic;
using System.Text;

namespace movie_schedule_manage
{
    public class MovieManager : CinemaBase , IMovieViewer
    {
        public MovieManager(int size) : base(size) 
        {
        }

        public bool AddMovie(string title, string time)
        {
            if(count >= movieTitles.Length)
            {
                Console.WriteLine("Cannot add more movies. Storage is full.");
                return false; // No more space
            }
            if(!IsValidTime(time))
            {
                Console.WriteLine("Invalid time format. Please use HH:MM format.");
                return false;
            }

            movieTitles[count] = title;
            showTimes[count] = time;
            count++;
            Console.WriteLine("Movie added successfully."); 
            return true;
        }

        public void DisplayMovie()
        {
            Console.WriteLine(" Movie Title          |  Show Time");
            Console.WriteLine("-------------------------------------");
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(FormatMovie(i));
            }
        }

        public void SearchMovie(string title)
        {
            bool found = false;
            Console.WriteLine(" Search Results for: " + title);
            Console.WriteLine(" Movie Title          |  Show Time");
            Console.WriteLine("-------------------------------------");
            for(int i = 0; i < count; i++)
            {
                if(movieTitles[i].ToLower().Contains(title.ToLower()))
                {
                    Console.WriteLine(FormatMovie(i));
                    found = true;
                }
            }
            if(!found)
            {
                Console.WriteLine("No movies found with the title: " + title);
            }
        }
        public int GetMovieCount()
        {
            return count;
        }
        public string[] GetTitles() 
        {
            return movieTitles;
        } 
        public string[] GetTimes() 
        {
            return showTimes;
        }
    }
}
