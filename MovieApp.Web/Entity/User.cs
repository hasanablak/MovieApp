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
}
