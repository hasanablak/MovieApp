namespace MovieApp.Web.Entity
{
    

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