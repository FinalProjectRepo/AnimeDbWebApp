using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using AnimeDbWebApp.Models.Enums;
using static AnimeDbWebApp.Common.ValidationConstants.MangaValidations;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

namespace AnimeDbWebApp.Models
{
    public class Manga
    {
        [Key]
        [Comment("Unique identifier that equals mal_id")]
        public int Id { get; set; }

        [MaxLength(MaxUrlLength)]
        [Comment("Url link to mal site")]
        public string? Url { get; set; }

        [MaxLength(MaxPosterUrlLength)]
        [Comment("Manga poster url")]
        public string? PosterUrl { get; set; }

        [Required]
        [Comment("Manga title")]
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; } = null!;

        [Comment("Manga title in english translated")]
        [MaxLength(MaxEngTitleLength)]
        public string? TitleEnglish { get; set; } = null!;

        [Comment("Manga title in japanese characters")]
        [MaxLength(MaxEngTitleLength)]
        public string? TitleJapanese { get; set; } = null!;

        [Comment("Number of chapters")]
        public int? Chapters { get; set; }

        [Comment("Number of volumes, chapters combined in")]
        public int? Volumes { get; set; }

        [Required]
        [Range(MinRangeMangaStatus, MaxRangeMangaStatus)]
        [Comment("Airing status")]
        public MangaStatus Status { get; set; }

        [Comment("Date manga started publishing")]
        [Column(TypeName = "DATETIME2")]
        public DateTime? StartDate { get; set; }

        [Comment("Date manga ended publishing")]
        [Column(TypeName = "DATETIME2")]
        public DateTime? EndDate { get; set; }

        [Comment("Manga score")]
        [Range(MinScore, MaxScore)]
        [Column(TypeName = "DECIMAL(4,2)")]
        public double? Score { get; set; }

        [Comment("Manga rank")]
        public int? Rank { get; set; }

        [Comment("Short description")]
        public string? Synopsis { get; set; }

        [Comment("Short pre-story")]
        public string? Background { get; set; }

        [Comment("Type of manga(manga, light novel, etc.)")]
        public int? TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public TypeForManga? Type { get; set; }

        public ICollection<MangaAuthor> MangasAuthors { get; set; } = [];
        public ICollection<MangaGenre> Genres { get; set; } = [];
        public ICollection<MangaRelation> MangaRalations { get; set; } = [];
        public ICollection<AnimeManga> Adaptations { get; set; } = [];
        public ICollection<MangaMagazine> MangasMagazines { get; set; } = [];
        public ICollection<AppUserManga> AppUsers { get; set; } = [];
    }
}