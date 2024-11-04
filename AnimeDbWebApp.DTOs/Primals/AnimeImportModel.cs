using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

using AnimeDbWebApp.Models.Enums;
using static AnimeDbWebApp.Common.ValidationConstants.AnimeValidation;

namespace AnimeDbWebApp.DTOs.Primals
{
    public class AnimeImportModel
    {
        [Key]
        [JsonProperty("mal_id")]
        public int Id { get; set; }

        [MaxLength(MaxUrlLength)]
        [JsonProperty("url")]
        public string? Url { get; set; }

        [MaxLength(MaxPosterUrlLength)]
        [JsonProperty("image")]
        public string? PosterUrl { get; set; }

        [MaxLength(MaxTrailerUrlLength)]
        [JsonProperty("trailer")]
        public string? TrailerUrl { get; set; }

        [Required]
        [MinLength(MinTitleLength)]
        [MaxLength(MaxTitleLength)]
        [JsonProperty("title")]
        public string Title { get; set; } = null!;

        [MaxLength(MaxEngTitleLength)]
        [JsonProperty("engtitle")]
        public string? TitleEnglish { get; set; } = null!;

        [MaxLength(MaxJapTitleLength)]
        [JsonProperty("jptitle")]
        public string? TitleJapanese { get; set; } = null!;

        [Required]
        [Range(MinEpisodes, MaxEpisodes)]
        public int Episodes { get; set; }

        [Required]
        [Comment("Airing status")]
        public Status Status { get; set; }

        [Comment("Airing start date")]
        [Column(TypeName = "DATETIME2")]
        public DateTime? StartDate { get; set; }

        [Comment("Last episode aired date")]
        [Column(TypeName = "DATETIME2")]
        public DateTime? EndDate { get; set; }

        [Required]
        [Comment("Duration of episode")]
        [MaxLength(MaxDurationLength)]
        public string? Duration { get; set; }

        [Required]
        [Comment("Age restriction for anime")]
        [MaxLength(MaxRatingLength)]
        public string? Rating { get; set; }

        [Required]
        [Comment("Populairty/liked score of anime")]
        [Range(MinScore, MaxScore)]
        [Column(TypeName = "DECIMAL(4,2)")]
        public double? Score { get; set; }

        [Required]
        [Comment("Anime rank")]
        public int? Rank { get; set; }

        [Required]
        [Comment("Short description")]
        public string Sypnosis { get; set; } = null!;

        [Required]
        [Comment("Short description")]
        public string Background { get; set; } = null!;

        [Required]
        [Comment("Yearly anime season that anime aired")]
        public Season Season { get; set; }

        [Required]
        [Comment("Type of anime(tv series, movie, etc.)")]
        public int TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public Type Type { get; set; } = null!;

        [Required]
        [MaxLength(MaxSourceLength)]
        public string Source { get; set; } = null!;
    }
}