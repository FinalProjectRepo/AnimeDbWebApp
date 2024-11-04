using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using static AnimeDbWebApp.Common.ValidationConstants.MagazineValidations;

namespace AnimeDbWebApp.DTOs.Primals
{
    public class MagazineImportModel
    {
        [JsonProperty("mal_id")]
        public int Id { get; set; }

        [MaxLength(MaxUrlLength)]
        [AllowNull]
        [JsonProperty("url")]
        public string? Url { get; set; }

        [Required]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        [JsonProperty("name")]
        public string Name { get; set; } = null!;
    }
}