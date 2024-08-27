using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MovieApp.Web.Entity
{
    public class Movie
    {
        /*
         ClassId veya sadece Id yapmamız lazım
         */
        public int MovieId { get; set; }


        [Required]
        
        public string Title { get; set; }

        [MaxLength(100)]

        public string Description { get; set; }


        //public string Director { get; set; }

        //public string[] Players { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public int GenreId { get; set; }
    }
}
