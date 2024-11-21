using System.Collections.Generic;
using AnimeDbWebApp.ViewModels.ExtraForUser;
using AnimeDbWebApp.ViewModels.Manga;

namespace AnimeDbWebApp.ViewModels.Generic
{
    public class GeneralWithCountViewModel<T> : InheritedForWatchingStatus
        where T : class 
	{
        public int TotalPages { get; set; }
        public int Page { get; set; }
        public int ItemsPerPage { get; set; }
        public string? Search { get; set; }
        public IList<T> Entities { get; set; } = [];
    }
}