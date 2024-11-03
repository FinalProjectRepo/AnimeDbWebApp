using Microsoft.EntityFrameworkCore;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

using AnimeDbWebApp.Models.Enums;
using static AnimeDbWebApp.Common.ValidationConstants.AnimeValidation;

namespace AnimeDbWebApp.Models
{
    public class Anime
    {
        [Key]
        [Comment("Unique identifier that equals mal_id")]
        public int Id { get; set; }

        [Comment("Url link to mal site")]
        [MaxLength(MaxUrlLength)]
        public string? Url { get; set; }

        [Comment("Anime poster url")]
        [MaxLength(MaxPosterUrlLength)]
        public string? PosterUrl { get; set; }

        [Comment("Anime trailer url")]
        [MaxLength(MaxTrailerUrlLength)]
        public string? TrailerUrl { get; set; }

        [Required]
        [Comment("Anime title")]
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; } = null!;

        [Comment("Anime title in english translated")]
        [MaxLength(MaxEngTitleLength)]
        public string? TitleEnglish { get; set; } = null!;

        [Comment("Anime title in japanese characters")]
        [MaxLength(MaxJapTitleLength)]
        public string? TitleJapanese { get; set; } = null!;

        [Required]
        [Comment("Source for creating the anime")]
        [MaxLength(MaxSourceLength)]
        public string Source { get; set; } = null!;

        [Required]
        [Comment("Number of episodes")]
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
        [MaxLength(MaxSypnosisLength)]
        public string Sypnosis { get; set; } = null!;

        [Required]
        [Comment("Short description")]
        [MaxLength(MaxBackgroundLength)]
        public string Background { get; set; } = null!;

        [Required]
        [Comment("Yearly anime season that anime aired")]
        public Season Season { get; set; }

        [Required]
        [Comment("Type of anime(tv series, movie, etc.)")]
        public int TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public Type Type { get; set; } = null!;

        public ICollection<AnimeProducer> AnimesProducers { get; set; } = [];
        public ICollection<AnimeLicensor> AnimesLicensors { get; set; } = [];
        public ICollection<AnimeStudio> AnimesStudios { get; set; } = [];
        public ICollection<AnimeGenre> Genres { get; set; } = [];
        public ICollection<AnimeRelation> AnimesRelations { get; set; } = [];
        public ICollection<AnimeManga> Adaptations { get; set; } = [];
    }
}