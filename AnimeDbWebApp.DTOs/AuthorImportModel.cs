using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

using static AnimeDbWebApp.Common.ValidationConstants.AuthorValidations;

namespace AnimeDbWebApp.DTOs
{
    public class AuthorImportModel
    {
        [JsonProperty("mal_id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        [MaxLength(MaxUrlLength)]
        [AllowNull]
        public string? Url { get; set; }

        [JsonProperty("website_url")]
        [MaxLength(MaxWebsiteUrlLength)]
        [AllowNull]
        public string? Website { get; set; }

        [JsonProperty("image")]
        [MaxLength(MaxPosterUrlLength)]
        [AllowNull]
        public string? PosterUrl { get; set; }

        [Required]
        [JsonProperty("name")]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        [JsonProperty("given_name")]
        [MaxLength(MaxGivenNameLength)]
        [AllowNull]
        public string? GivenName { get; set; } = null!;

        [JsonProperty("family_name")]
        [MaxLength(MaxFamilyNameLength)]
        [AllowNull]
        public string? FamilyName { get; set; } = null!;

        [JsonProperty("birthday")]
        public string? Birthdate { get; set; }

        [JsonProperty("about")]
        public string? About { get; set; }
    }
}