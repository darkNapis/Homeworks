using System;
using HomeworkLINQ.Entities;
using HomeworkLINQ.Helpers;
using System.Linq;
using System.Collections.Generic;

namespace HomeworkLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = MoviesHelpers.GetAllMovies();

            //*Find all movies that their titles starts with "L"

            // Lambda syntax
            var findAllMoviesStartingWithL = movies
                                .Where(movie => movie.Title.StartsWith('L')).ToList();

            // Sql query syntax 
            var findAllMoviesStartingWithLQuery = (from movie in movies
                                                   where movie.Title.StartsWith('L')
                                                   select movie.Title).ToList();

            foreach (var movie in findAllMoviesStartingWithL)
            {
                Console.WriteLine(movie.Title);
            }

            //*Find the NUMBER of movies that have rating higher than 7.5

            var findNumberOfMoviesWithRatingHigherThanSevenPointFive = movies
                                                .Where(movie => movie.Rating > 7.5).Count();

            var findNumberOfMoviesWithRatingHigherThanSevenPointFiveQuery = (from movie in movies
                                                                             where movie.Rating > 7.5
                                                                             select movie.Rating).Count();

            Console.WriteLine(findNumberOfMoviesWithRatingHigherThanSevenPointFive);

            //*Find all movies TITLES with year of production before 2005

            var findAllMoviesTitlesBefore2005 = movies.FindAll(movie => movie.Year < 2005).ToList();

            var findAllMoviesTitlesBefore2005Query = (from movie in movies
                                                      where movie.Year < 2005
                                                      select movie.Title).ToList();
            foreach (var title in findAllMoviesTitlesBefore2005)
            {
                Console.WriteLine(title.Title);
            }

            //*Find all movies TITLES and RATING that have rating higher then 8.0

            var findAllMoviesTitleAndRatingHigherThan8 = movies.FindAll(movie => movie.Rating > 8).ToList();

            var findAllMoviesTitleAndRatingHigherThan8Query = (from movie in movies
                                                               where movie.Rating > 8
                                                               select movie.Title).ToList();

            foreach (var movie in findAllMoviesTitleAndRatingHigherThan8)
            {
                Console.WriteLine(movie.Title);
            }

            //*Find first 5 movies that have duration time longer then 2 hours

            var firstFiveMoviesWithDurationLongerThan2Hours = movies.Where(movie => movie.Duration > 120).Take(5).ToList();

            var firstFiveMoviesWithDurationLongerThan2HoursQuery = (from movie in movies
                                                                    where movie.Duration > 120
                                                                    select movie.Title).Take(5).ToList();

            foreach (var movie in firstFiveMoviesWithDurationLongerThan2HoursQuery)
            {
                Console.WriteLine(movie);
            }

            //*Find last 3 movies TITLES and DURATION that have duration less then 2 hours

            var findLast3MoviesWithDurationLessThan2Hours = movies
                        .Where(movie => movie.Duration < 120).TakeLast(3).ToList();

            var findLast3MoviesWithDurationLessThan2HoursQuery = (from movie in movies
                                                                  where movie.Duration < 120
                                                                  select movie.Title).TakeLast(3).ToList();

            foreach (var movie in findLast3MoviesWithDurationLessThan2Hours)
            {
                Console.WriteLine($"{movie.Title} " + $" {movie.Duration}");
            }

            //*Find all movies TITLES and RATING and order them by DURATION(DESC) -no condition needed

            var findAllMoviesByDurationDesk = movies
                        .OrderByDescending(movie => movie.Duration)
                        .Select(movie => new { Title = movie.Title, Rating = movie.Rating })
                        .ToList();

            foreach (var item in findAllMoviesByDurationDesk)
            {
                Console.WriteLine($"{item.Title} " + $" {item.Rating}");
            }

            //*Find all movies with TITLES that don't start with A and TITLES include more than 7 characters

            var findAllMoviesThatDontStartWithAandHaveMoreThan7char = movies
                        .Where(movie => movie.Title.Length > 7
                        && !movie.Title.StartsWith('A'))
                        .ToList();

            movies.ForEach(movie => Console.WriteLine(movie.Title));

            //*Find all movies RATINGS that have RATINGS higher than 7.2, DURATIONS less then 1hour
            // and 50min

            var findAllMoviesRatingsHigher7Point2AndDurationLess110 = movies
                        .FindAll(movie => movie.Rating > 7.2
                        && movie.Duration < 110)
                        .ToList();

            foreach (var rating in findAllMoviesRatingsHigher7Point2AndDurationLess110)
            {
                Console.WriteLine(rating.Rating);
            }

            //*Find all movies TITLES and RATINGS that have TITLES with less than 10 characters, DURATION
            // longer than 2 hours, RATING higher then 6.7 and order them by TITLE(ASC)

            var findAllMoviesWithTitlesLess10charRatingHigher6Point7DurationLonger2Hours = movies
                            .Where(movie => movie.Title.Length < 10)
                            .Where(movie => movie.Rating > 6.7)
                            .Where(movie => movie.Duration > 120)
                            .ToList();

            foreach (var item in findAllMoviesWithTitlesLess10charRatingHigher6Point7DurationLonger2Hours)
            {
                Console.WriteLine($"{item.Title} " + $" {item.Rating}");
            }

            Console.ReadLine();
        }
    }
}
