using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnimeDbWebApp.Models
{
    public class AuthorManga
    {
        [Required]
        [Comment("Unique identifier of manga")]
        public int MangaId { get; set; }
        [ForeignKey(nameof(MangaId))]
        public Manga Manga { get; set; } = null!;

        [Required]
        [Comment("Unique identifier of author")]
        public int AuthorId { get; set; }
        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; } = null!;
    }
}