namespace AnimeDbWebApp.ViewModels.Manga
{
	public class MangaViewModel
	{
		public int Id { get; set; }
		public string? PosterUrl { get; set; }
		public string Title { get; set; } = null!;
		public int? Chapters { get; set; }
		public int? Volumes { get; set; }
		public string Status { get; set; } = null!;
		public string? StartDate { get; set; }
		public string? EndDate { get; set; }
		public string? Type { get; set; }
	}
}