using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using static AnimeDbWebApp.Common.ValidationConstants.RelationValidations;

namespace AnimeDbWebApp.Models
{
    public class AnimeRelation
    {
        [Required]
        [Comment("Unique identifier of anime")]
        public int AnimeId { get; set; }
        [ForeignKey(nameof(AnimeId))]
        public Anime Anime { get; set; } = null!;

        [Required]
        [Comment("Unique identifier of anime that have relation to animeId")]
        public int RelationId { get; set; }
        [ForeignKey(nameof(RelationId))]
        public Anime Relation { get; set; } = null!;

        [Required]
        [Comment("Type of relation that animes have")]
        [MaxLength(MaxRelationTypeLength)]
        public string RelationType { get; set; } = null!;
    }
}