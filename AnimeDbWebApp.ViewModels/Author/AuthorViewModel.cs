using System;

namespace AnimeDbWebApp.ViewModels.Author
{
	public class AuthorViewModel
	{
		public int Id { get; set; }
		public string? PosterUrl { get; set; }
		public string Name { get; set; } = null!;
		public DateTime? Birthdate { get; set; }
	}
}