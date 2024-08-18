using MovieApp.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Data
{
    public class MovieRepository
    {
        private static readonly List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie{
                    MovieId = 1,
                    Title = "Film1",
                    Director = "Director1",
                    Description = "Description1",
                    Players = new string[]{"player1.1", "player1.2"},
                    ImageUrl = "attack.jpg"
                },

                new Movie{
                    MovieId = 2,
                    Title = "Film2",
                    Director = "Director2",
                    Description = "Description2",
                    Players = new string[]{"player2.1", "player2.2"},
                    ImageUrl = "batman.jpg"
                },

                new Movie{
                    MovieId = 3,
                    Title = "Film3",
                    Director = "Director3",
                    Description = "Description3",
                    Players = new string[]{"player3.1", "player3.2"},
                    ImageUrl = "attack.jpg"
                },

                new Movie{
                    MovieId = 4,
                    Title = "Film3",
                    Director = "Director3",
                    Description = "Description3",
                    Players = new string[]{"player4.1", "player4.2"},
                    ImageUrl = "batman.jpg"
                },


            };
        }

        public static List<Movie> Movies
        {
            get { return _movies; }
        }

        public static void Add(Movie movie){
            _movies.Add(movie);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(movie => movie.MovieId == id);
        }
    }
}
