using AnimeDbWebApp.Models.Enums;
using AnimeDbWebApp.ViewModels.Anime;

namespace AnimeDbWebApp.ViewModels.Added
{
	public class AddedAnimeViewModel : AnimeViewModel
    {
        public WatchingStatus WatchingStatus { get; set; }
	}
}