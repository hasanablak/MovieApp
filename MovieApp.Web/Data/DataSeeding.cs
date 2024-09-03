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
            // 'dotnet ef database update' gibi yani
            context.Database.Migrate();
            
            // Bekleyen bir migration yok ise 
            if(context.Database.GetPendingMigrations().Count() == 0)
            {
                var genres = GetGenresForSeeding();


                var movies = GetMoviesForSeeding(genres);

                var users = GetUsersForSeeding();

                var peoples = GetPeoplesForSeeding(users);

                var crews = GetCrewsForSeeding(movies, peoples);

                var casts = GetCastsForSeeding(movies, peoples);





                // Eğer içeride bir Genre kaydı yok ise
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(genres);
                }

                if(context.Users.Count() == 0)
                {
                    context.Users.AddRange();
                }

                if (context.People.Count() == 0)
                {
                    context.People.AddRange(peoples);
                }

                if (context.Crews.Count() == 0)
                {
                    context.Crews.AddRange(crews);
                }

                if (context.Casts.Count() == 0)
                {
                    context.Casts.AddRange(casts);
                }

                // Eğer içeride bir Movie kaydı yok ise
                if (context.Movies.Count() == 0)
                {
                    context.Movies.AddRange(movies);
                }



                context.SaveChanges();
            }

        }
        private static List<User> GetUsersForSeeding()
        {
            var users = new List<User>()
            {
                new User
                {
                    Name = "Hasan Ablak",
                    Email = "0hasanablak@gmail.com",
                    Password = "password",
                    UserName = "hasanablak"
                },
                new User
                {
                    Name = "Ümmügülsüm Ablak",
                    Email = "ummu@gmail.com",
                    Password = "password",
                    UserName = "ummugulsum"
                },
               new User
                {
                    Name = "John Doe",
                    Email = "johndoe@gmail.com",
                    Password = "password",
                    UserName = "johndoe"
                },

               new User
                {
                    Name = "Fahrettin Eroğlu",
                    Email = "fahrettin@gmail.com",
                    Password = "password",
                    UserName = "fahrettin"
                },

               new User
                {
                    Name = "Ahmet Kazım",
                    Email = "ahmetkazim@gmail.com",
                    Password = "password",
                    UserName = "ahmetkazim"
                },
            };

            return users;
        }
        private static List<Person> GetPeoplesForSeeding(List<User> users){

            var peoples = new List<Person>()
            {

                new Person()
                {
                    Biography = "1997 Büyükçekmece Doğumlu",
                    User = users[0]
                },

                new Person()
                {
                    Biography = "Lorem ipsum dolar sit amet",
                    User = users[1]
                },
                new Person()
                {
                    Biography = "1997 Büyükçekmece Doğumlu",
                    User = users[2]
                },

                new Person()
                {
                    Biography = "Lorem ipsum dolar sit amet",
                    User = users[3]
                },
                new Person()
                {
                    Biography = "Lorem ipsum dolar sit amet",
                    User = users[4]
                }

            };

            return peoples;

        }

        private static List<Crew> GetCrewsForSeeding(List<Movie> movies, List<Person> peoples) {
            var crew = new List<Crew>()
            {
                new Crew() {
                    Movie = movies[0],
                    Person = peoples[0],
                    Job = "Yönetmen"
                },
                 new Crew() {
                    Movie = movies[0],
                    Person = peoples[1],
                    Job = "Yönetmen Yardımcısı"
                },
                 new Crew() {
                    Movie = movies[0],
                    Person = peoples[2],
                    Job = "Oyuncu"
                },
                 new Crew() {
                    Movie = movies[0],
                    Person = peoples[3],
                    Job = "Oyuncu"
                },
                 new Crew() {
                    Movie = movies[0],
                    Person = peoples[4],
                    Job = "Oyuncu"
                }
            };

            return crew;
        }
        private static List<Cast> GetCastsForSeeding(List<Movie> movies, List<Person> peoples)
        {
            var casts = new List<Cast>()
            {
                new Cast() {
                    Movie = movies[0],
                    Person = peoples[2],
                    Name = "Mehmet Efendi",
                    Character = "Baba"
                },
                 new Cast() {
                    Movie = movies[0],
                    Person = peoples[3],
                    Name = "Muharrem Bey",
                    Character = "Camii İmamı"
                },
                 new Cast() {
                    Movie = movies[0],
                    Person = peoples[4],
                    Name = "Aziz Nesin",
                    Character = "Şair"
                }
            };

            return casts;
        }
        private static List<Movie> GetMoviesForSeeding(List<Genre> genres)
        {
            var movies = new List<Movie>()
            {
                new Movie{
                    Title = "Inception",
                    Description = "A thief who enters the dreams of others to steal secrets from their subconscious is given a chance to have his criminal history erased as payment for implanting an idea into the mind of a CEO.",
                    ImageUrl = "inception.jpg",
                    Genres = new List<Genre> { genres[0], genres[1] }
                },

                new Movie{
                    Title = "The Dark Knight",
                    Description = "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham, forcing Batman to accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    ImageUrl = "dark_knight.jpg"
                },

                new Movie{
                    Title = "Interstellar",
                    Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                    ImageUrl = "interstellar.webp"
                },

                new Movie{
                    Title = "The Matrix",
                    Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                    ImageUrl = "matrix.jpg"
                },

                new Movie{
                    Title = "Pulp Fiction",
                    Description = "The lives of two mob hitmen, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    ImageUrl = "pulp_fiction.jpg"
                },

                new Movie{
                    Title = "The Shawshank Redemption",
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    ImageUrl = "shawshank.jpg"

                },

                new Movie{
                    Title = "Forrest Gump",
                    Description = "The presidencies of Kennedy and Johnson, the events of Vietnam, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                    ImageUrl = "forrest_gump.webp"
                },

                new Movie{
                    Title = "Gladiator",
                    Description = "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.",
                    ImageUrl = "gladiator.jpg"
                },

                new Movie{
                    Title = "The Godfather",
                    Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                    ImageUrl = "godfather.jpg"
                },

                new Movie{
                    Title = "Jurassic Park",
                    Description = "During a preview tour, a theme park suffers a major power breakdown that allows its cloned dinosaur exhibits to run amok.",
                    ImageUrl = "jurassic_park.webp"
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
                    Name = "Macera"
                },
                new Genre
                {
                    Name = "Komedi"
                },
                new Genre
                {
                    Name = "Bilim Kurgu"
                },
                new Genre
                {
                    Name = "Savaş"
                }
            };

            return genres;
        }
    }
}
