using System.Collections.Generic;

namespace AnimeDbWebApp.ViewModels.Home
{
    public class HomeViewModel
    {
        public ICollection<AnimeHomeViewModel> Animes { get; set; } = [];
        public ICollection<MangaHomeViewModel> Mangas { get; set; } = [];
    }
}