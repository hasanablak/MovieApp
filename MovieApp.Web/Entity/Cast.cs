namespace MovieApp.Web.Entity
{
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
