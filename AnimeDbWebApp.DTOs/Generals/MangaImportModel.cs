using Newtonsoft.Json;

using System;
using System.ComponentModel.DataAnnotations;

using AnimeDbWebApp.Models.Enums;
using static AnimeDbWebApp.Common.ValidationConstants.MangaValidations;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

namespace AnimeDbWebApp.DTOs.Generals
{
    public class MangaImportModel
    {

        [JsonProperty("mal_id")]
        public int Id { get; set; }

        [MaxLength(MaxUrlLength)]
        [JsonProperty("url")]
        public string? Url { get; set; }

        [MaxLength(MaxPosterUrlLength)]
        [JsonProperty("image")]
        public string? PosterUrl { get; set; }

        [Required]
        [MaxLength(MaxTitleLength)]
        [JsonProperty("title")]
        public string Title { get; set; } = null!;

        [MaxLength(MaxEngTitleLength)]
        [JsonProperty("engtitle")]
        public string? TitleEnglish { get; set; } = null!;

        [MaxLength(MaxEngTitleLength)]
        [JsonProperty("jptitle")]
        public string? TitleJapanese { get; set; } = null!;
        
        [JsonProperty("chapters")]
        public int? Chapters { get; set; }

        [JsonProperty("volumes")]
        public int? Volumes { get; set; }

        [Required]
        [Range(MinRangeMangaStatus, MaxRangeMangaStatus)]
        [JsonProperty("status")]
        public MangaStatus Status { get; set; }

        [JsonProperty("from")]
        public DateTime? StartDate { get; set; } = null!;

        [JsonProperty("to")]
        public DateTime? EndDate { get; set; } = null!;

        [Range(MinScore, MaxScore)]
        [JsonProperty("score")]
        public double? Score { get; set; }

        [JsonProperty("rank")]
        public int? Rank { get; set; }

        [JsonProperty("synopsis")]
        public string? Synopsis { get; set; }

        [JsonProperty("background")]
        public string? Background { get; set; }

        [JsonProperty("type")]
        public int? TypeId { get; set; }
    }
}