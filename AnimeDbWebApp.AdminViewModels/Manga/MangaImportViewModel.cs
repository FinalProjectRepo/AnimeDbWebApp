using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;

using AnimeDbWebApp.Models.Enums;
using AnimeDbWebApp.Models;
using static AnimeDbWebApp.Common.ValidationConstants.MangaValidations;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;
using AnimeDbWebApp.AdminViewModels.SelectEnum;

namespace AnimeDbWebApp.AdminViewModels.Manga
{
	public class MangaImportViewModel : MangaStatusEnumSelect
	{
		public int Id { get; set; }

		[MaxLength(MaxUrlLength)]
		public string? Url { get; set; }

		[MaxLength(MaxPosterUrlLength)]
		public string? PosterUrl { get; set; }

		[Required]
		[MinLength(MinTitleLength)]
		[MaxLength(MaxTitleLength)]
		public string Title { get; set; } = null!;

		[MaxLength(MaxEngTitleLength)]
		public string? TitleEnglish { get; set; } = null!;

		[MaxLength(MaxEngTitleLength)]
		public string? TitleJapanese { get; set; } = null!;

		public int? Chapters { get; set; }

		public int? Volumes { get; set; }

		[Required]
		[Range(MinRangeMangaStatus, MaxRangeMangaStatus)]
		public MangaStatus Status { get; set; }

		public string? StartDate { get; set; }

		public string? EndDate { get; set; }

		[Range(MinScore, MaxScore)]
		public double? Score { get; set; }

		public int? Rank { get; set; }

		public string? Synopsis { get; set; }

		public string? Background { get; set; }

		public int? TypeId { get; set; }

		public ICollection<BasicClassForList> TypeList { get; set; } = [];
	}
}