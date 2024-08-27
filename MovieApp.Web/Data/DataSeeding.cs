using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Web.Entity;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Data
{
    public static class DataSeeding
    {

        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();

            var context = scope.ServiceProvider.GetService<MovieContext>();

            // Bekleyen bir migrate var ise, execute!
            context.Database.Migrate();
            
            // Bekleyen bir migration yok ise 
            if(context.Database.GetPendingMigrations().Count() == 0)
            {
                // Eğer içeride bir Movie kaydı yok ise
                if(context.Movies.Count() == 0)
                {
                    context.Movies.AddRange(GetMoviesForSeeding());
                }
                // Eğer içeride bir Genre kaydı yok ise
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(GetGenresForSeeding());
                }


                context.SaveChanges();
            }

        }

        private static List<Movie> GetMoviesForSeeding()
        {
            var movies = new List<Movie>()
            {
                new Movie{
                    MovieId = 1,
                    Title = "Inception",
                    Description = "A thief who enters the dreams of others to steal secrets from their subconscious is given a chance to have his criminal history erased as payment for implanting an idea into the mind of a CEO.",
                    ImageUrl = "inception.jpg",
                    GenreId = 1
                },

                new Movie{
                    MovieId = 2,
                    Title = "The Dark Knight",
                    Description = "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham, forcing Batman to accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    ImageUrl = "dark_knight.jpg",
                    GenreId = 2
                },

                new Movie{
                    MovieId = 3,
                    Title = "Interstellar",
                    Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                    ImageUrl = "interstellar.webp",
                    GenreId = 1
                },

                new Movie{
                    MovieId = 4,
                    Title = "The Matrix",
                    Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                    ImageUrl = "matrix.jpg",
                    GenreId = 2
                },

                new Movie{
                    MovieId = 5,
                    Title = "Pulp Fiction",
                    Description = "The lives of two mob hitmen, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    ImageUrl = "pulp_fiction.jpg",
                    GenreId = 3
                },

                new Movie{
                    MovieId = 6,
                    Title = "The Shawshank Redemption",
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    ImageUrl = "shawshank.jpg",
                    GenreId = 3

                },

                new Movie{
                    MovieId = 7,
                    Title = "Forrest Gump",
                    Description = "The presidencies of Kennedy and Johnson, the events of Vietnam, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                    ImageUrl = "forrest_gump.webp",
                    GenreId = 3
                },

                new Movie{
                    MovieId = 8,
                    Title = "Gladiator",
                    Description = "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.",
                    ImageUrl = "gladiator.jpg",
                    GenreId = 2
                },

                new Movie{
                    MovieId = 9,
                    Title = "The Godfather",
                    Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                    ImageUrl = "godfather.jpg",
                    GenreId=1
                },

                new Movie{
                    MovieId = 10,
                    Title = "Jurassic Park",
                    Description = "During a preview tour, a theme park suffers a major power breakdown that allows its cloned dinosaur exhibits to run amok.",
                    ImageUrl = "jurassic_park.webp",
                    GenreId = 3
                }
            };

            return movies;
        }

        private static List<Genre> GetGenresForSeeding()
        {
            var genres = new List<Genre>()
            {
                new Genre
                {
                    GenreId = 1,
                    Name = "Macera"
                },
                new Genre
                {
                    GenreId = 2,
                    Name = "Komedi"
                },
                new Genre
                {
                    GenreId = 3,
                    Name = "Bilim Kurgu"
                },
                new Genre
                {
                    GenreId = 4,
                    Name = "Savaş"
                }
            };

            return genres;
        }
    }
}
