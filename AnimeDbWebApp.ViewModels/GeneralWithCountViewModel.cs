using System.Collections.Generic;
using AnimeDbWebApp.ViewModels.Manga;

namespace AnimeDbWebApp.ViewModels
{
	public class GeneralWithCountViewModel<T> where T : class
	{
		public int TotalPages { get; set; }
		public int Page { get; set; }
		public int ItemsPerPage { get; set; }
		public string? Search { get; set; }
		public IList<T> Entities { get; set; } = [];
		public Dictionary<int, int> UserAddedEntities { get; set; } = new Dictionary<int, int>();
	}
}