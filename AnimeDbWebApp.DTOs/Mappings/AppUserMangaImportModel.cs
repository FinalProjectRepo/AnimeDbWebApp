using System.ComponentModel.DataAnnotations;

using AnimeDbWebApp.Models.Enums;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

namespace AnimeDbWebApp.DTOs.Mappings
{
	public class AppUserMangaImportModel
	{
		[Required]
		public int Id { get; set; }

		[Required]
		public string UserId { get; set; } = null!;

		[Required]
		[Range(MinRangeWatchingStatus, MaxRangeWatchingStatus)]
		public WatchingStatus WatchingStatus { get; set; }
	}
}