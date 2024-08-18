using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System;
using System.Collections.Generic;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            /*
             title, desc, manager, players[]

             */

            string title = "Starwars";
            string desc = "Güzel bir film";
            string manager = "Hasan Ablak";
            string[] players =
            {
                "Mehmet", "Ahmet"
            };



            var movie = new Movie();

            movie.Title = title;
            movie.Description = desc;
            movie.Director = manager;
            movie.Players = players;
            movie.ImageUrl = "starwars.jpg";

            ViewBag.movie = movie;

            return View(movie);
        }
        public IActionResult List()
        {
           
            var movieList = new List<Movie>()
            {
                new Movie{
                    Title = "Film1",
                    Director = "Director1",
                    Description = "Description1",
                    Players = new string[]{"player1.1", "player1.2"},
                    ImageUrl = "attack.jpg"
                },

                new Movie{
                    Title = "Film2",
                    Director = "Director2",
                    Description = "Description2",
                    Players = new string[]{"player2.1", "player2.2"},
                    ImageUrl = "batman.jpg"
                },

                new Movie{
                    Title = "Film3",
                    Director = "Director3",
                    Description = "Description3",
                    Players = new string[]{"player3.1", "player3.2"},
                    ImageUrl = "attack.jpg"
                },

                new Movie{
                    Title = "Film3",
                    Director = "Director3",
                    Description = "Description3",
                    Players = new string[]{"player4.1", "player4.2"},
                    ImageUrl = "batman.jpg"
                },


            };


            var model = new MovieGenreViewModel()
            {
                Movies = movieList
            };


            return View("CustomList", model);
        }

        public IActionResult Details(string id)
        {
            

            return View();
        }

    }
}
