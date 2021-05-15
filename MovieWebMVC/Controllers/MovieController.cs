using Microsoft.AspNetCore.Mvc;
using MovieWebMVC.Domain;
using MovieWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebMVC.Controllers
{
    public class MovieController : Controller
    {
        private List<Movie> movieDB = new List<Movie>()
        {
            new Movie()
            {
                Id = 1,
                Title = "The Lionking",
                Description = "The best movie ever",
                Genre = "Animatie film",
                Price = (decimal)4.99,
                Rating = 5,
                Director = "Jon Favreau",
                ReleaseDate = new DateTime(1994, 5, 4)
            },
            new Movie()
            {
                Id = 2,
                Title = "The Titanic",
                Description = "The worst movie ever",
                Genre = "Drama",
                Price = (decimal)0.99,
                Rating = 1,
                Director = "James Cameron",
                ReleaseDate = new DateTime(1998, 1, 7)
            },
            new Movie()
            {
                Id = 3,
                Title = "Deadpool",
                Description = "The funniest movie ever",
                Genre = "Action",
                Price = (decimal)3.99,
                Rating = 1,
                Director = "Tim Miller",
                ReleaseDate = new DateTime(2016, 2, 10)
            }
        };

        public IActionResult Index()
        {
            List<MovieListViewModel> movies = new List<MovieListViewModel>();

            foreach (Movie movie in movieDB)
            {
                movies.Add(new MovieListViewModel() { Id = movie.Id, Title = movie.Title });
            }

            return View(movies);
        }

        public IActionResult Detail()
        {
            var movie = new Movie()
            {
                Title = "The Lionking",
                Description = "The best movie ever",
                Genre = "Animatie film",
                Price = (decimal)4.99,
                Rating = 5,
                Director = "Jon Favreau",
                ReleaseDate = new DateTime(1994, 5, 4)
            };

            return View(new MovieDetailViewModel() { Title = movie.Title, Description = movie.Description, ReleaseDate = movie.ReleaseDate });
        }
    }
}
