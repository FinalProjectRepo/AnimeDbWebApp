using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

using AnimeDbWebApp.Models.Enums;
using AnimeDbWebApp.Models;
using static AnimeDbWebApp.Common.ValidationConstants.AnimeValidation;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

namespace AnimeDbWebApp.Areas.Admin.Models
{
	public class AnimeImportViewModel
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

		public DateTime? StartDate { get; set; }

		public DateTime? EndDate { get; set; }

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

		[ForeignKey(nameof(SourceId))]
		public Source Source { get; set; } = null!;

		public int? TypeId { get; set; }

		[ForeignKey(nameof(TypeId))]
		public TypeForAnime? Type { get; set; }
	}
}