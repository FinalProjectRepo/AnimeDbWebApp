using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

using static AnimeDbWebApp.Common.ValidationConstants.AuthorValidations;

namespace AnimeDbWebApp.AdminViewModels.Author
{
    public class AuthorApiImportModel
    {
        [MaxLength(MaxUrlLength)]
        [AllowNull]
        public string? Url { get; set; }

        [MaxLength(MaxWebsiteUrlLength)]
        [AllowNull]
        public string? Website { get; set; }

        [MaxLength(MaxPosterUrlLength)]
        [AllowNull]
        public string? PosterUrl { get; set; }

        [Required]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        [MaxLength(MaxGivenNameLength)]
        [AllowNull]
        public string? GivenName { get; set; } = null!;

        [MaxLength(MaxFamilyNameLength)]
        [AllowNull]
        public string? FamilyName { get; set; } = null!;

        public string? Birthdate { get; set; }

        public string? About { get; set; }
    }
}