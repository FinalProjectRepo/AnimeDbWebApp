namespace AnimeDbWebApp.ViewModels.Anime
{
	public class AnimeViewModel
    {
		public int Id { get; set; }
		public string? PosterUrl { get; set; }
		public string Title { get; set; } = null!;
		public int? Episodes { get; set; }
		public string? Status { get; set; }
		public string? Duration { get; set; }
		public string? StartDate { get; set; }
		public string? EndDate { get; set; }
		public string? Type { get; set; }
	}
}