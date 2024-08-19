using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;
using System.Collections.Generic;

namespace MovieApp.Web.ViewComponents
{
    public class GenresViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var genres = GenreRepository.Genres;

            ViewBag.SelectedGenre = RouteData.Values["id"];
            return View(genres);
        }
    }
}
