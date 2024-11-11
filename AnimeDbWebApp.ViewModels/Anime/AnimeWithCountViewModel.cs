using System.Collections.Generic;

namespace AnimeDbWebApp.ViewModels.Anime
{
    public class AnimeWithCountViewModel
    {
        public int TotalPages { get; set; }
        public int Page { get; set; }
        public int ItemsPerPage { get; set; }
        public string? Search { get; set; }
        public IList<AnimeViewModel> Animes { get; set; } = [];
    }
}