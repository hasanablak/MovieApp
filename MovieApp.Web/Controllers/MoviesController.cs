using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;
using System;
using System.Collections.Generic;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomePageViewModel
            {
                PopularMovies = MovieRepository.Movies
            };

            return View(model);
        }
        public IActionResult List()
        {
           
            


            var model = new MoviesViewModel()
            {
                Movies = MovieRepository.Movies
            };


            return View("CustomList", model);
        }

        public IActionResult Details(int id)
        {
            

            return View(MovieRepository.GetById(id));
        }

    }
}
