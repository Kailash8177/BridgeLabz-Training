using System;
using System.Collections.Generic;
using System.Text;

namespace movie_schedule_manage
{
    internal interface IMovieViewer
    {
        void DisplayMovie();
        void SearchMovie(string title);
    }
}
