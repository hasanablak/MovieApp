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
		// 03.09.2024: Çoka çok olması için +1 tablo ef tarafından oluşturulacak yani "GenreMovie" tablosu ef tarafından oluşturulacak
		public List<Movie> Movies { get; set; }
	}
}
