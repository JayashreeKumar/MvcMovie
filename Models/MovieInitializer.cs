using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class MovieInitializer : DropCreateDatabaseAlways<MovieDBContext>
    {
        protected override void Seed(MovieDBContext context)
        {
            var movies = new List<Movie>
            {
                new Movie {
                    Title = "Hello World",
                    ReleaseDate = DateTime.Parse("2012-07-20"),
                    Genre = "Intro",
                    Rating = "G",
                    Price = 10
                },
                new Movie {
                    Title = "Now",
                    ReleaseDate = DateTime.Parse("2012-07-21"),
                    Genre = "Life",
                    Rating = "M",
                    Price = 10
                },
                new Movie {
                    Title = "Too Late",
                    ReleaseDate = DateTime.Parse("2012-07-22"),
                    Genre = "Life",
                    Rating = "M",
                    Price = 10
                },
                new Movie {
                    Title = "MVC4",
                    ReleaseDate = DateTime.Parse("2012-07-23"),
                    Genre = "Intro",
                    Rating = "G",
                    Price = 10
                }
            };

            movies.ForEach(m => context.Movies.Add(m));
        }
    }
}