using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieApp.Web.Data;
using MovieApp.Web.Entity;
using MovieApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Controllers
{

    public class MoviesController : Controller
    {

        private readonly MovieContext _context;

        public MoviesController(MovieContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = new HomePageViewModel
            {
                PopularMovies = MovieRepository.Movies
            };

            return View(model);
        }
        //movies/list/
        //movies/list/1
        public IActionResult List(int? id, string? keyword)
        {
            var controller = RouteData.Values["controller"]; // List(int?id, string controller) da yapılabilir
            var action = RouteData.Values["action"];
            var genreId = RouteData.Values["id"];

            //var keyword = HttpContext.Request.Query["keyword"].toString();

            //var movies = MovieRepository.Movies;

            var movies = _context.Movies.AsQueryable();

            if (id != null)
            {

                movies = movies.Where(movie => movie.GenreId == id);

            }

            if (!string.IsNullOrEmpty(keyword)) {
                movies = movies
                    .Where(movie => movie.Title.ToLower().Contains(keyword) || movie.Description.ToLower().Contains(keyword));
            }


            var model = new MoviesViewModel()
            {
                Movies = movies.ToList()
            };


            if(id != null)
            {
                model.Genre = GenreRepository.GetById(Convert.ToInt32(genreId));
            }



            return View("CustomList", model);
        }

        public IActionResult Details(int id)
        {
            

            return View(MovieRepository.GetById(id));
        }

        public IActionResult Search(string? keyword)
        {
            var movies = MovieRepository.GetByKeyword(keyword);

            var matchedMovies = movies
                .Where(movie => movie.Title.ToLower().Contains(keyword) || movie.Description.ToLower().Contains(keyword))
                .ToList();
            return Json(matchedMovies);
        }

        public IActionResult Create()
        {
            ViewBag.Message = TempData["message"]?.ToString() ?? null;
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View();
        }


        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {

                //MovieRepository.Add(movie);
                _context.Movies.Add(movie);
                _context.SaveChanges();
                //ViewBag.Message = "Created with successfully";

                TempData["Message"] = "Film Oluşturuldu";
                return RedirectToAction("List");

            }

            ViewBag.Message = "Gerekli Alanları Doldurunuz!";


            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View();
        }

        public IActionResult Update(int id)
        {
           var movie =  MovieRepository.GetById(id);

            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");

            return View(movie);
        }

        [HttpPost]
        public IActionResult Update(int id, Movie movie) {

            if (ModelState.IsValid)
            {
                movie.MovieId = id;
                MovieRepository.UpdateMovieById(movie);

                TempData["Message"] = $"{movie.Title} Güncellendi";

                return RedirectToAction("Details", "Movies", new { @id = movie.MovieId });
               
            }


            ViewBag.Message = "Gerekli Alanları Doldurunuz!";

            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");

            return View(movie);

        }


        [HttpPost]
        public IActionResult Delete(int id) {

            var movie = MovieRepository.GetById(id);

            MovieRepository.DeleteById(id);
            
            TempData["Message"] = $"{movie.Title} Silindi";

            return RedirectToAction("List");
        }





    }
}
