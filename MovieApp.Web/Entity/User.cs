using System.ComponentModel.DataAnnotations;

namespace MovieApp.Web.Entity
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }
    }
}
