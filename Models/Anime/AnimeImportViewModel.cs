using Microsoft.EntityFrameworkCore;

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Generic;

using AnimeDbWebApp.Models.Enums;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Areas.Admin.Models.SelectEnum;
using static AnimeDbWebApp.Common.ValidationConstants.AnimeValidation;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

namespace AnimeDbWebApp.Areas.Admin.Models.Anime
{
    public class AnimeImportViewModel : SeasonStatusEnumSelect
	{
        [MaxLength(MaxUrlLength)]
        public string? Url { get; set; }

        [MaxLength(MaxPosterUrlLength)]
        public string? PosterUrl { get; set; }

        [MaxLength(MaxTrailerUrlLength)]
        public string? TrailerUrl { get; set; }

        [Required]
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; } = null!;

        [MaxLength(MaxEngTitleLength)]
        public string? TitleEnglish { get; set; } = null!;

        [MaxLength(MaxJapTitleLength)]
        public string? TitleJapanese { get; set; } = null!;

        [Range(MinEpisodes, MaxEpisodes)]
        public int? Episodes { get; set; }

        [Required]
        [Range(MinRangeAnimeStatus, MaxRangeAnimeStatus)]
        public AnimeStatus Status { get; set; }

        public string? StartDate { get; set; }

        public string? EndDate { get; set; }

        [MaxLength(MaxDurationLength)]
        public string? Duration { get; set; }

        [MaxLength(MaxRatingLength)]
        public string? Rating { get; set; }

        [Range(MinScore, MaxScore)]
        public double? Score { get; set; }

        public int? Rank { get; set; }

        public string? Synopsis { get; set; } = null!;

        public string? Background { get; set; } = null!;

        [Range(MinRangeSeason, MaxRangeMangaStatus)]
        public Season? Season { get; set; }

        [Required]
        public int SourceId { get; set; }

        public int? TypeId { get; set; }

        public ICollection<Type> TypeList { get; set; } = [];
        public ICollection<Source> SourceList { get; set; } = [];
    }
}