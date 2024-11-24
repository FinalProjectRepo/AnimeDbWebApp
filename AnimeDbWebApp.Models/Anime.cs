using Microsoft.EntityFrameworkCore;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

using AnimeDbWebApp.Models.Enums;
using static AnimeDbWebApp.Common.ValidationConstants.AnimeValidation;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

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

        [Comment("Number of episodes")]
        [Range(MinEpisodes, MaxEpisodes)]
        public int? Episodes { get; set; }

        [Required]
        [Comment("Airing status")]
        [Range(MinRangeAnimeStatus, MaxRangeAnimeStatus)]
        public AnimeStatus Status { get; set; }

        [Comment("Airing start date")]
        [Column(TypeName = "DATETIME2")]
        public DateTime? StartDate { get; set; }

        [Comment("Last episode aired date")]
        [Column(TypeName = "DATETIME2")]
        public DateTime? EndDate { get; set; }

        [Comment("Duration of episode")]
        [MaxLength(MaxDurationLength)]
        public string? Duration { get; set; }

        [Comment("Age restriction for anime")]
        [MaxLength(MaxRatingLength)]
        public string? Rating { get; set; }

        [Comment("Populairty/liked score of anime")]
        [Range(MinScore, MaxScore)]
        [Column(TypeName = "DECIMAL(4,2)")]
        public double? Score { get; set; }

        [Comment("Anime rank")]
        public int? Rank { get; set; }

        [Comment("Short description")]
        public string? Synopsis { get; set; } = null!;

        [Comment("Short description")]
        public string? Background { get; set; } = null!;

        [Comment("Yearly anime season that anime aired")]
        [Range(MinRangeSeason, MaxRangeMangaStatus)]
        public Season? Season { get; set; }

        [Required]
        [Comment("Source for creating the anime")]
        public int SourceId { get; set; }

        [ForeignKey(nameof(SourceId))]
        public Source Source { get; set; } = null!;

		[Comment("Type of anime(tv series, movie, etc.)")]
        public int? TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public TypeForAnime? Type { get; set; }

        public ICollection<AnimeProducer> AnimesProducers { get; set; } = [];
        public ICollection<AnimeLicensor> AnimesLicensors { get; set; } = [];
        public ICollection<AnimeStudio> AnimesStudios { get; set; } = [];
        public ICollection<AnimeGenre> Genres { get; set; } = [];
        public ICollection<AnimeRelation> AnimesRelations { get; set; } = [];
        public ICollection<AnimeManga> MangaAdaptations { get; set; } = [];
        public ICollection<AppUserAnime> AppUsers { get; set; } = [];
    }
}