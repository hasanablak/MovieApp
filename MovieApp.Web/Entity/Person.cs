namespace MovieApp.Web.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string UserName { get; set; }


        public string ImageUrl { get; set; }

        public Person Person { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }



        public string Biography { get; set; }

        public string Imdb { get; set; }

        public string PersonalHomePage { get; set; }

        public string PlaceOfBirth { get; set; }

        public User User { get; set; }

        public int UserId { get; set; } // foreing key, uniqie key
    }

    public class Crew
    {

        public int Id { get; set; }

        public Movie Movie { get; set; }
        public int MovieId { get; set; }

        public Person Person { get; set; }
        public int PersonId { get; set; }

        public string Job { get; set; }

    }

    public class Cast
    {
        public int Id { get; set; }

        public Movie Movie { get; set; }
        public int MovieId { get; set; }

        public Person Person { get; set; }
        public int PersonId { get; set; }
        public string Name { get; set; }

        public string Character { get; set; }
    }
}