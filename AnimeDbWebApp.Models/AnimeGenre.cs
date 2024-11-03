using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnimeDbWebApp.Models
{
    public class AnimeGenre
    {
        [Required]
        [Comment("Unique identifier of anime")]
        public int AnimeId { get; set; }
        [ForeignKey(nameof(AnimeId))]
        public Anime Anime { get; set; } = null!;

        [Required]
        [Comment("Unique identifier of genre")]
        public int GenreId { get; set; }
        [ForeignKey(nameof(GenreId))]
        public GenreForAnime Genre { get; set; } = null!;
    }
}
