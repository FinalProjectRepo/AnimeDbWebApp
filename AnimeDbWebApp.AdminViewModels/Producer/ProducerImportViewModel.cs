using System.ComponentModel.DataAnnotations;

using static AnimeDbWebApp.Common.ValidationConstants.ProducerValidations;

namespace AnimeDbWebApp.AdminViewModels.Producer
{
	public class ProducerImportViewModel
	{
		public int Id { get; set; }

		[MaxLength(MaxUrlLength)]
		public string? Url { get; set; }

		[Required]
		[MinLength(MinNameLength)]
		[MaxLength(MaxNameLength)]
		public string Name { get; set; } = null!;

		[MaxLength(MaxJpNameLength)]
		public string? JpName { get; set; }

		[MaxLength(MaxImgUrlLength)]
		public string? ImgUrl { get; set; }

		public string? Established { get; set; }

		public string? About { get; set; }
	}
}