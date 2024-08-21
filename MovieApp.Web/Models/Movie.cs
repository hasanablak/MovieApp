using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Web.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [DisplayName("Başlık")]

        [Required(ErrorMessage = "Başlık Zorunludur")]
        [StringLength(100, ErrorMessage ="Başlık 100 Karakteri Geçemez")]
        public string Title { get; set; }

        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "Açıklama Zorunludur")]
        public string Description { get; set; }

        [DisplayName("Yönetmen")]
        [Required(ErrorMessage = "Yönetmen Zorunludur")]
        public string Director { get; set; }

        public string[] Players { get; set; }

        [DisplayName("Kapak URL")]
        [Required(ErrorMessage = "Kapak Url Zorunludur")]
        public string ImageUrl { get; set; }


        [DisplayName("Film Kategorisi")]
        [Required(ErrorMessage = "Kategori Seçimi Zorunludur")]
        public int? GenreId { get; set; }
    }
}
