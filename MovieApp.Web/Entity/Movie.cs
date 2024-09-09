using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace MovieApp.Web.Entity
{
	public class Movie
	{
		/*
         ClassId veya sadece Id yapmamız lazım
         */
		public int MovieId { get; set; }


		[Required]
		//[Column(TypeName = "varchar(200))]

		public string Title { get; set; }

		[MaxLength(250)]

		public string Description { get; set; }


		//public string Director { get; set; }

		//public string[] Players { get; set; }

		[Required]
		public string ImageUrl { get; set; }

		// 03.09.2024: Çoka çok olması için +1 tablo ef tarafından oluşturulacak yani "GenreMovie" tablosu ef tarafından oluşturulacak
		public List<Genre> Genres { get; set; }

	}
}
