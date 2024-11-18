using System.Collections.Generic;
using System;
using AnimeDbWebApp.ViewModels.MappingCollections;

namespace AnimeDbWebApp.ViewModels.Producer
{
    public class ProducerDetailsViewModel
	{
		public int Id { get; set; }
		public string? Url { get; set; }
		public string Name { get; set; } = null!;
		public string? JpName { get; set; }
		public string? ImgUrl { get; set; }
		public string? Established { get; set; }
		public string? About { get; set; }

		public ICollection<MappingForGeneralViewModel> AnimesProducers { get; set; } = [];
		public ICollection<MappingForGeneralViewModel> AnimesLicensors { get; set; } = [];
		public ICollection<MappingForGeneralViewModel> AnimesStudios { get; set; } = [];
	}
}