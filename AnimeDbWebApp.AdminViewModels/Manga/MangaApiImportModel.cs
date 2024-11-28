using System.ComponentModel.DataAnnotations;

using AnimeDbWebApp.Models.Enums;
using static AnimeDbWebApp.Common.ValidationConstants.MangaValidations;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

namespace AnimeDbWebApp.AdminViewModels.Manga
{
    public class MangaApiImportModel
    {
        [MaxLength(MaxUrlLength)]
        public string? Url { get; set; }

        [MaxLength(MaxPosterUrlLength)]
        public string? PosterUrl { get; set; }

        [Required]
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

        public string? StartDate { get; set; } = null!;

        public string? EndDate { get; set; } = null!;

        [Range(MinScore, MaxScore)]
        public double? Score { get; set; }

        public int? Rank { get; set; }

        public string? Synopsis { get; set; }

        public string? Background { get; set; }

        public int? TypeId { get; set; }
    }
}