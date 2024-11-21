using System.Collections.Generic;
using AnimeDbWebApp.ViewModels.ExtraForUser;
using AnimeDbWebApp.ViewModels.MappingCollections;

namespace AnimeDbWebApp.ViewModels.Manga
{
    public class MangaDetailsViewModel : InheritedForWatchingStatus
	{
		public int Id { get; set; }
		public string? Url { get; set; }
		public string? PosterUrl { get; set; }
		public string Title { get; set; } = null!;
		public string? TitleEnglish { get; set; } = null!;
		public string? TitleJapanese { get; set; } = null!;
		public int? Chapters { get; set; }
		public int? Volumes { get; set; }
		public string Status { get; set; } = null!;
		public string? StartDate { get; set; }
		public string? EndDate { get; set; }
		public double? Score { get; set; }
		public int? Rank { get; set; }
		public string? Synopsis { get; set; }
		public string? Background { get; set; }
		public string? Type { get; set; }

		public ICollection<MappingForNonRelationViewModel> MangasAuthors { get; set; } = [];
		public ICollection<string> Genres { get; set; } = [];
		public ICollection<MappingForRelationViewModel> MangaRelations { get; set; } = [];
		public ICollection<MappingForGeneralViewModel> AnimeAdaptations { get; set; } = [];
		public ICollection<MappingForNonRelationViewModel> MangasMagazines { get; set; } = [];
	}
}