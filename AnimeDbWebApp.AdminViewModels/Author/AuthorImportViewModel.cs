using System.ComponentModel.DataAnnotations;

using static AnimeDbWebApp.Common.ValidationConstants.AuthorValidations;

namespace AnimeDbWebApp.AdminViewModels.Author
{
	public class AuthorImportViewModel
	{
		public int Id { get; set; }

		[MaxLength(MaxUrlLength)]
		public string? Url { get; set; }

		[MaxLength(MaxWebsiteUrlLength)]
		public string? Website { get; set; }

		[MaxLength(MaxPosterUrlLength)]
		public string? PosterUrl { get; set; }

		[Required]
		[MinLength(MinNameLength)]
		[MaxLength(MaxNameLength)]
		public string Name { get; set; } = null!;

		[MaxLength(MaxGivenNameLength)]
		public string? GivenName { get; set; }

		[MaxLength(MaxFamilyNameLength)]
		public string? FamilyName { get; set; }

		public string? Birthdate { get; set; }

		public string? About { get; set; }
	}
}