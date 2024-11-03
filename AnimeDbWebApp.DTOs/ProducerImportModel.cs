using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

using static AnimeDbWebApp.Common.ValidationConstants.ProducerValidations;

namespace AnimeDbWebApp.DTOs
{
    public class ProducerImportModel
    {
        [Required]
        [JsonProperty("mal_id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        [MaxLength(MaxUrlLength)]
        [AllowNull]
        public string? Url { get; set; }

        [JsonProperty("name")]
        [Required]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        [JsonProperty("jpname")]
        [MaxLength(MaxJpNameLength)]
        [AllowNull]
        public string? JpName { get; set; } = null!;

        [JsonProperty("image")]
        [MaxLength(MaxImgUrlLength)]
        [AllowNull]
        public string? ImgUrl { get; set; }

        [JsonProperty("established")]
        public string? Established { get; set; }

        [JsonProperty("about")]
        public string? About { get; set; }
    }
}