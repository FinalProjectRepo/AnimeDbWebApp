using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using AnimeDbWebApp.Models.Enums;
using static AnimeDbWebApp.Common.ValidationConstants.MangaValidations;

namespace AnimeDbWebApp.Models
{
    public class Manga
    {
        [Key]
        [Comment("Unique identifier that equals mal_id")]
        public int Id { get; set; }

        [Comment("Url link to mal site")]
        public string? Url { get; set; }

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

        [Required]
        [Comment("Number of chapters")]
        public int? Chapters { get; set; }

        [Required]
        [Comment("Number of volumes, chapters combined in")]
        public int? Volumes { get; set; }

        [Required]
        [Comment("Airing status")]
        public Status Status { get; set; }

        [Required]
        [Comment("Date manga started publishing")]
        [Column(TypeName = "DATETIME2")]
        public DateTime? StartDate { get; set; } = null!;

        [Required]
        [Comment("Date manga ended publishing")]
        [Column(TypeName = "DATETIME2")]
        public DateTime? EndDate { get; set; } = null!;

        [Required]
        [Comment("Manga score")]
        [Range(MinScore, MaxScore)]
        [Column(TypeName = "DECIMAL(4,2)")]
        public double? Score { get; set; }

        [Required]
        [Comment("Manga rank")]
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
        [Comment("Type of anime(tv series, movie, etc.)")]
        public int TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public Type Type { get; set; } = null!;

        public ICollection<AuthorManga> AuthorsMangas { get; set; } = [];
        public ICollection<GenreForManga> Genres { get; set; } = [];
        public ICollection<MangaRelation> MangaRalations { get; set; } = [];
        public ICollection<AnimeManga> Adaptations { get; set; } = [];
    }
}