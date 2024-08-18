using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System.Collections.Generic;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var genreList = new List<Genre>()
            {
                new Genre
                {
                    Name = "Macera"
                },
                new Genre
                {
                    Name = "Komedi"
                },
                new Genre
                {
                    Name = "Bilim Kurgu"
                }
            };
            var model = new MovieGenreViewModel()
            {
                Genres = genreList
            };

            return View(model);
        }
    }
}
