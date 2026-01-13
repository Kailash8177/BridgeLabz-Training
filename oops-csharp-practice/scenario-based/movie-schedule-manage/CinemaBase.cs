using System;
using System.Collections.Generic;
using System.Text;

namespace movie_schedule_manage
{
    public abstract class CinemaBase
    {
        protected string[] movieTitles;
        protected string[] showTimes;
        protected int count;

        protected CinemaBase(int size)
        {
            movieTitles = new string[size];
            showTimes = new string[size];
            count = 0;
        }


        protected bool IsValidTime(string time)
        {
            // Simple validation for HH:MM format
            if (TimeSpan.TryParse(time, out _))
            {
                return true;
            }
            return false;
        }

        protected string FormatMovie(int index)
        {
            return string.Format(" {0,-20} |  {1}",
                movieTitles[index], showTimes[index]);
        }
    }
}
