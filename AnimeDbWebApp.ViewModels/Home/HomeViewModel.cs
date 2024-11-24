using System.Collections.Generic;

namespace AnimeDbWebApp.ViewModels.Home
{
    public class HomeViewModel
    {
        public IList<AnimeHomeViewModel> Animes { get; set; } = [];
        public IList<MangaHomeViewModel> Mangas { get; set; } = [];
    }
}