﻿using MovieApp.Web.Models;
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
                    Title = "Inception",
                    Director = "Christopher Nolan",
                    Description = "A thief who enters the dreams of others to steal secrets from their subconscious is given a chance to have his criminal history erased as payment for implanting an idea into the mind of a CEO.",
                    Players = new string[]{"Leonardo DiCaprio", "Joseph Gordon-Levitt"},
                    ImageUrl = "inception.jpg",
                    GenreId = 1
                },

                new Movie{
                    MovieId = 2,
                    Title = "The Dark Knight",
                    Director = "Christopher Nolan",
                    Description = "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham, forcing Batman to accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Players = new string[]{"Christian Bale", "Heath Ledger"},
                    ImageUrl = "dark_knight.jpg",
                    GenreId = 2
                },

                new Movie{
                    MovieId = 3,
                    Title = "Interstellar",
                    Director = "Christopher Nolan",
                    Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                    Players = new string[]{"Matthew McConaughey", "Anne Hathaway"},
                    ImageUrl = "interstellar.webp",
                    GenreId = 1
                },

                new Movie{
                    MovieId = 4,
                    Title = "The Matrix",
                    Director = "The Wachowskis",
                    Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                    Players = new string[]{"Keanu Reeves", "Laurence Fishburne"},
                    ImageUrl = "matrix.jpg",
                    GenreId = 2
                },

                new Movie{
                    MovieId = 5,
                    Title = "Pulp Fiction",
                    Director = "Quentin Tarantino",
                    Description = "The lives of two mob hitmen, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    Players = new string[]{"John Travolta", "Uma Thurman"},
                    ImageUrl = "pulp_fiction.jpg",
                    GenreId = 3
                },

                new Movie{
                    MovieId = 6,
                    Title = "The Shawshank Redemption",
                    Director = "Frank Darabont",
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Players = new string[]{"Tim Robbins", "Morgan Freeman"},
                    ImageUrl = "shawshank.jpg",
                    GenreId = 3
                    
                },

                new Movie{
                    MovieId = 7,
                    Title = "Forrest Gump",
                    Director = "Robert Zemeckis",
                    Description = "The presidencies of Kennedy and Johnson, the events of Vietnam, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                    Players = new string[]{"Tom Hanks", "Robin Wright"},
                    ImageUrl = "forrest_gump.webp",
                    GenreId = 3
                },

                new Movie{
                    MovieId = 8,
                    Title = "Gladiator",
                    Director = "Ridley Scott",
                    Description = "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.",
                    Players = new string[]{"Russell Crowe", "Joaquin Phoenix"},
                    ImageUrl = "gladiator.jpg",
                    GenreId = 2
                },

                new Movie{
                    MovieId = 9,
                    Title = "The Godfather",
                    Director = "Francis Ford Coppola",
                    Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                    Players = new string[]{"Marlon Brando", "Al Pacino"},
                    ImageUrl = "godfather.jpg",
                    GenreId=1
                },

                new Movie{
                    MovieId = 10,
                    Title = "Jurassic Park",
                    Director = "Steven Spielberg",
                    Description = "During a preview tour, a theme park suffers a major power breakdown that allows its cloned dinosaur exhibits to run amok.",
                    Players = new string[]{"Sam Neill", "Laura Dern"},
                    ImageUrl = "jurassic_park.webp",
                    GenreId = 3
                }
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
