using System.Collections.Generic;
using AnimeDbWebApp.ViewModels.MappingCollections;

namespace AnimeDbWebApp.ViewModels.Magazine
{
	public class MagazineDetailsViewModel
	{
		public int Id { get; set; }
		public string? Url { get; set; }
		public string Name { get; set; } = null!;
		
		public ICollection<MappingForGeneralViewModel> MangasMagazines { get; set; } = [];
	}
}