using System;

namespace AnimeDbWebApp.ViewModels.Producer
{
	public class ProducerViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string? ImgUrl { get; set; }
		public DateTime? Established { get; set; }
	}
}