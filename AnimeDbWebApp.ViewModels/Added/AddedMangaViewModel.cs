using AnimeDbWebApp.Models.Enums;
using AnimeDbWebApp.ViewModels.Manga;

namespace AnimeDbWebApp.ViewModels.Added
{
	public class AddedMangaViewModel : MangaViewModel
    {
        public WatchingStatus WatchingStatus { get; set; }
	}
}