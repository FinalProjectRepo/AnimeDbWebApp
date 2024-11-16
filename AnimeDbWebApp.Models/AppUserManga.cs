using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

using AnimeDbWebApp.Models.Enums;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

namespace AnimeDbWebApp.Models
{
    public class AppUserManga
    {
        [Required]
        [Comment("Unique identifier of manga")]
        public int MangaId { get; set; }
        [ForeignKey(nameof(MangaId))]
        public Manga Manga { get; set; } = null!;

        [Required]
        [Comment("User unique identifier")]
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; } = null!;

        [Required]
        [Comment("Watching status")]
        [Range(MinRangeWatchingStatus, MaxRangeWatchingStatus)]
        public WatchingStatus Status { get; set; }
    }
}