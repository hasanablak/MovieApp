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

}