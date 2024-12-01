using System.Collections.Generic;

namespace AnimeDbWebApp.ViewModels.Generic
{
	public class PrimalWithCountViewModel<T> where T : class
    {
        public int TotalPages { get; set; }
        public int Page { get; set; }
        public int ItemsPerPage { get; set; }
        public string? Search { get; set; }
        public IList<T> Entities { get; set; } = [];
    }
}