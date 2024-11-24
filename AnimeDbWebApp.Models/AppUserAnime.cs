using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

using AnimeDbWebApp.Models.Enums;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

namespace AnimeDbWebApp.Models
{
    public class AppUserAnime
    {
        [Required]
        [Comment("Unique identifier of anime")]
        public int Id { get; set; }

        [ForeignKey(nameof(Id))]
        public Anime Anime { get; set; } = null!;

		[Required]
		[Comment("User unique identifier")]
		public Guid UserId { get; set; }

		[ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; } = null!;

		[Required]
		[Comment("Watching status")]
		[Range(MinRangeWatchingStatus, MaxRangeWatchingStatus)]
		public WatchingStatus WatchingStatus { get; set; }
	}
}