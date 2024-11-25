using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using static AnimeDbWebApp.Common.ValidationConstants.MagazineValidations;

namespace AnimeDbWebApp.AdminViewModels.Magazine
{
	public class MagazineImportViewModel
	{
		public int Id { get; set; }

		[MaxLength(MaxUrlLength)]
		public string? Url { get; set; }

		[Required]
		[MinLength(MinNameLength)]
		[MaxLength(MaxNameLength)]
		public string Name { get; set; } = null!;
	}
}