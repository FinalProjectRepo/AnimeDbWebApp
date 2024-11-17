using System.Collections.Generic;

namespace AnimeDbWebApp.ViewModels.Manga
{
	public class MangaWithCountViewModel
	{
		public int TotalPages { get; set; }
		public int Page { get; set; }
		public int ItemsPerPage { get; set; }
		public string? Search { get; set; }
		public IList<MangaViewModel> Mangas { get; set; } = [];
		public Dictionary<int, int> AddedMangas { get; set; } = new Dictionary<int, int>();
	}
}