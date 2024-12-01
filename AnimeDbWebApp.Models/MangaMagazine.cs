using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnimeDbWebApp.Models
{
    public class MangaMagazine
    {
        [Required]
        [Comment("Unique identifier of manga")]
        public int MangaId { get; set; }
        [ForeignKey(nameof(MangaId))]
        public Manga Manga { get; set; } = null!;

        [Required]
        [Comment("Unique identifier of magazine")]
        public int MagazineId { get; set; }
        [ForeignKey(nameof(MagazineId))]
        public Magazine Magazine { get; set; } = null!;
    }
}