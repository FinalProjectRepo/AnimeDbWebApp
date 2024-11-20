using AnimeDbWebApp.ViewModels.Manga;

namespace AnimeDbWebApp.ViewModels.Added
{
	public class AddedMangaViewModel : MangaDetailsViewModel
	{
		public string WatchingStatus { get; set; } = null!;
	}
}