using System.Collections.Generic;
using System;

namespace AnimeDbWebApp.ViewModels.Manga
{
	public class MangaDetailsViewModel
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

		public ICollection<AuthorsForMangaViewModel> MangasAuthors { get; set; } = [];
		public ICollection<string> Genres { get; set; } = [];
		public ICollection<RelationForMangaViewModel> MangaRelations { get; set; } = [];
		public ICollection<AdaptationForMangaViewModel> Adaptations { get; set; } = [];
		public ICollection<MagazineForMangaViewModel> MangasMagazines { get; set; } = [];
	}

	public class AuthorsForMangaViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
	}

	public class RelationForMangaViewModel
	{
		public int Id { get; set; }
		public string Title { get; set; } = null!;
		public string RelationType { get; set; } = null!;
	}

	public class AdaptationForMangaViewModel
	{
		public int Id { get; set; }
		public string Title { get; set; } = null!;
	}

	public class MagazineForMangaViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
	}
}