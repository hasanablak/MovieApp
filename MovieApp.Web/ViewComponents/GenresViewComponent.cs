using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System.Collections.Generic;

namespace MovieApp.Web.ViewComponents
{
    public class GenresViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
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

            return View(genreList);
        }
    }
}
