﻿using Newtonsoft.Json;

using System;
using System.ComponentModel.DataAnnotations;

using AnimeDbWebApp.Models.Enums;
using static AnimeDbWebApp.Common.ValidationConstants.AnimeValidation;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

namespace AnimeDbWebApp.DTOs.Generals
{
    public class AnimeImportModel
    {
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
        [JsonProperty("episodes")]
        public int? Episodes { get; set; }

        [Required]
        [Range(MinRangeAnimeStatus, MaxRangeAnimeStatus)]
        [JsonProperty("status")]
        public AnimeStatus Status { get; set; }

        [JsonProperty("from")]
        public DateTime? StartDate { get; set; }

        [JsonProperty("to")]
        public DateTime? EndDate { get; set; }

        [MaxLength(MaxDurationLength)]
        [JsonProperty("duration")]
        public string? Duration { get; set; }

        [MaxLength(MaxRatingLength)]
        [JsonProperty("rating")]
        public string? Rating { get; set; }

        [Range(MinScore, MaxScore)]
        [JsonProperty("score")]
        public double? Score { get; set; }

        [JsonProperty("rank")]
        public int? Rank { get; set; }

        [JsonProperty("synopsis")]
        public string? Synopsis { get; set; } = null!;

        [JsonProperty("background")]
        public string? Background { get; set; } = null!;

        [Required]
        [JsonProperty("season")]
        [Range(MinRangeSeason, MaxRangeSeason)]
        public Season? Season { get; set; }

		[Required]
		[JsonProperty("source")]
        public int SourceId { get; set; }

		[JsonProperty("type")]
        public int? TypeId { get; set; }
    }
}