using System.Collections.Generic;
using System;

namespace AnimeDbWebApp.ViewModels.Anime
{
	public class AnimeDetailsViewModel
	{
		public int Id { get; set; }
		public string? Url { get; set; }
		public string? PosterUrl { get; set; }
		public string? TrailerUrl { get; set; }
		public string Title { get; set; } = null!;
		public string? TitleEnglish { get; set; } = null!;
		public string? TitleJapanese { get; set; } = null!;
		public int? Episodes { get; set; }
		public string Status { get; set; } = null!;
		public string? StartDate { get; set; }
		public string? EndDate { get; set; }
		public string? Duration { get; set; }
		public string? Rating { get; set; }
		public double? Score { get; set; }
		public int? Rank { get; set; }
		public string? Synopsis { get; set; } = null!;
		public string? Background { get; set; } = null!;
		public string? Season { get; set; }
		public string Source { get; set; } = null!;
		public string? Type { get; set; }

		public ICollection<ProducerForAnimeViewModel> AnimesProducers { get; set; } = [];
		public ICollection<string> AnimesLicensors { get; set; } = [];
		public ICollection<string> AnimesStudios { get; set; } = [];
		public ICollection<string> AnimeGenre { get; set; } = [];
		public ICollection<string> AnimesRelations { get; set; } = [];
		public ICollection<string> Adaptations { get; set; } = [];
	}

	public class ProducerForAnimeViewModel
	{
		public int Id { get; set; }
		public string ImgUrl { get; set; } = null!;
	}
}