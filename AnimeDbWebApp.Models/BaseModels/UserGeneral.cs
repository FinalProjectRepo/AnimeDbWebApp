using Microsoft.EntityFrameworkCore;

using System;
using System.ComponentModel.DataAnnotations;

using AnimeDbWebApp.Models.Enums;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

namespace AnimeDbWebApp.Models.BaseModels
{
	public class UserGeneral
	{
		public int Id { get; set; }

		[Required]
		[Comment("User unique identifier")]
		public Guid UserId { get; set; }

		[Required]
		[Comment("Watching status")]
		[Range(MinRangeWatchingStatus, MaxRangeWatchingStatus)]
		public WatchingStatus WatchingStatus { get; set; }
	}
}