using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnimeDbWebApp.Models
{
    public class MangaGenre
    {
        [Required]
        [Comment("Unique identifier of manga")]
        public int MangaId { get; set; }
        [ForeignKey(nameof(MangaId))]
        public Manga Manga { get; set; } = null!;

        [Required]
        [Comment("Unique identifier of genre")]
        public int GenreId { get; set; }
        [ForeignKey(nameof(GenreId))]
        public GenreForManga Genre { get; set; } = null!;
    }
}