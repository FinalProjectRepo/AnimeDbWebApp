using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnimeDbWebApp.Models
{
    public class MangaRelation
    {
        [Required]
        [Comment("Unique identifier of manga")]
        public int MangaId { get; set; }
        [ForeignKey(nameof(MangaId))]
        public Manga Manga { get; set; } = null!;

        [Required]
        [Comment("Unique identifier of manga that have relation to mangaId")]
        public int RelationId { get; set; }
        [ForeignKey(nameof(RelationId))]
        public Manga Relation { get; set; } = null!;

        [Required]
        [Comment("Type of relation that mangas have")]
        public string RelationType { get; set; } = null!;
    }
}