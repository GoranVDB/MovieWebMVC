using Microsoft.AspNetCore.Mvc;
using MovieWebMVC.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebMVC.Controllers
{
    public class MovieController : Controller
    {
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
            return View(movie);
        }
    }
}
