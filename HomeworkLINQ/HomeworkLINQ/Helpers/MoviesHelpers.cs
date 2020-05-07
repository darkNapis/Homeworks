using HomeworkLINQ.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkLINQ.Helpers
{
    public class MoviesHelpers
    {
        public static List<Movie> GetAllMovies()
        {
            return new List<Movie>()
            {
                new Movie(){ Title = "Snatch", Year = 2000, Rating = 8.3f, Duration = 104 },
                new Movie(){ Title = "The Bank Job", Year = 2008, Rating = 7.2f, Duration = 111 },
                new Movie(){ Title = "Lock, Stock and Two Smoking Barrels", Year = 1998, Rating = 8.2f, Duration = 107 },
                new Movie(){ Title = "The Gentlemen", Year = 2019, Rating = 7.9f, Duration = 113 },
                new Movie(){ Title = "RocknRolla", Year = 2008, Rating = 7.3f, Duration = 114 },
                new Movie(){ Title = "The Mechanic", Year = 2011, Rating = 6.6f, Duration = 93 },
                new Movie(){ Title = "Fight Club", Year = 1999, Rating = 8.8f, Duration = 139 },
                new Movie(){ Title = "The Equalizer", Year = 2014, Rating = 7.2f, Duration = 132 },
                new Movie(){ Title = "Thor", Year = 2011, Rating = 7.0f, Duration = 115 },
                new Movie(){ Title = "Dark Waters", Year = 2019, Rating = 7.6f, Duration = 126 },
                new Movie(){ Title = "Gone Girl", Year = 2014, Rating = 8.1f, Duration = 149 },
                new Movie(){ Title = "Taken", Year = 2008, Rating = 7.8f, Duration = 90 }
            };
        }
    }
}
