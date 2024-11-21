using AnimeDbWebApp.Models.Enums;
using AnimeDbWebApp.ViewModels.Anime;
using AnimeDbWebApp.ViewModels.MappingCollections;
using System.Collections.Generic;

namespace AnimeDbWebApp.ViewModels.Added
{
	public class AddedAnimeViewModel : AnimeViewModel
    {
        public WatchingStatus WatchingStatus { get; set; }
	}
}