using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimeDbWebApp.Models
{
    public class AnimeProducer
    {
        [Required]
        [Comment("Unique identifier of anime")]
        public int AnimeId { get; set; }
        [ForeignKey(nameof(AnimeId))]
        public Anime Anime { get; set; } = null!;

        [Required]
        [Comment("Unique identifier of producer")]
        public int ProducerId { get; set; }
        [ForeignKey(nameof(ProducerId))]
        public Producer Producer { get; set; } = null!;
    }
}