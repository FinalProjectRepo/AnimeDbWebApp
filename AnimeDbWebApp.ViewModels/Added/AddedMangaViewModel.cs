using AnimeDbWebApp.Models.Enums;
using AnimeDbWebApp.ViewModels.Manga;
using AnimeDbWebApp.ViewModels.MappingCollections;
using System.Collections.Generic;

namespace AnimeDbWebApp.ViewModels.Added
{
	public class AddedMangaViewModel : MangaViewModel
    {
        public WatchingStatus WatchingStatus { get; set; }
	}
}