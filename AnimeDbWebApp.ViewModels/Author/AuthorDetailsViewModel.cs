using System.Collections.Generic;

using AnimeDbWebApp.ViewModels.MappingCollections;

namespace AnimeDbWebApp.ViewModels.Author
{
	public class AuthorDetailsViewModel
	{
		public string? Url { get; set; }
		public string? Website { get; set; }
		public string? PosterUrl { get; set; }
		public string Name { get; set; } = null!;
		public string? GivenName { get; set; }
		public string? FamilyName { get; set; }
		public string? Birthdate { get; set; }
		public string? About { get; set; }

		public ICollection<MappingForGeneralViewModel> MangasAuthors { get; set; } = [];
	}
}