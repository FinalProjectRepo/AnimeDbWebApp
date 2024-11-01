using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnimeDbWebApp.Models
{
    public class AnimeLicensor
    {
        [Required]
        [Comment("Unique identifier of anime")]
        public int AnimeId { get; set; }
        [ForeignKey(nameof(AnimeId))]
        public Anime Anime { get; set; } = null!;

        [Required]
        [Comment("Unique identifier of licensor(producer)")]
        public int LicensorId { get; set; }
        [ForeignKey(nameof(LicensorId))]
        public Producer Licensor { get; set; } = null!;
    }
}