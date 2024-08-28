using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Web.Entity
{
    public class Genre
    {
        public int GenreId { get; set; }

        [Required]
        public string Name { get; set; }

        /*
         Anladığım kadarıyla, navigation propertyler veritabanında bir kolon eklemekten çok
         bir index'i ifade ediyor.
         */
        public List<Movie> Movies { get; set; } // Navigation property
    }
}
