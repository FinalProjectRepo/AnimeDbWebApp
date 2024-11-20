using System.Collections.Generic;
using AnimeDbWebApp.ViewModels.Generic;
using AnimeDbWebApp.ViewModels.MappingCollections;

namespace AnimeDbWebApp.ViewModels.Anime
{
    public class AnimeDetailsViewModel : GeneralDetailsViewModel
	{
		public int Id { get; set; }
		public string? Url { get; set; }
		public string? PosterUrl { get; set; }
		public string? TrailerUrl { get; set; }
		public string Title { get; set; } = null!;
		public string? TitleEnglish { get; set; } = null!;
		public string? TitleJapanese { get; set; } = null!;
		public int? Episodes { get; set; }
		public string Status { get; set; } = null!;
		public string? StartDate { get; set; }
		public string? EndDate { get; set; }
		public string? Duration { get; set; }
		public string? Rating { get; set; }
		public double? Score { get; set; }
		public int? Rank { get; set; }
		public string? Synopsis { get; set; } = null!;
		public string? Background { get; set; } = null!;
		public string? Season { get; set; }
		public string Source { get; set; } = null!;
		public string? Type { get; set; }

		public ICollection<MappingForNonRelationViewModel> AnimesProducers { get; set; } = [];
		public ICollection<MappingForNonRelationViewModel> AnimesLicensors { get; set; } = [];
		public ICollection<MappingForNonRelationViewModel> AnimesStudios { get; set; } = [];
		public ICollection<string> Genres { get; set; } = [];
		public ICollection<MappingForRelationViewModel> AnimesRelations { get; set; } = [];
		public ICollection<MappingForGeneralViewModel> MangaAdaptations { get; set; } = [];
	}
}