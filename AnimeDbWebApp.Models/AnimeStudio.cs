using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnimeDbWebApp.Models
{
    public class AnimeStudio
    {
        [Required]
        [Comment("Unique identifier of anime")]
        public int AnimeId { get; set; }
        [ForeignKey(nameof(AnimeId))]
        public Anime Anime { get; set; } = null!;

        [Required]
        [Comment("Unique identifier of studio(producer)")]
        public int StudioId { get; set; }
        [ForeignKey(nameof(StudioId))]
        public Producer Studio { get; set; } = null!;
    }
}