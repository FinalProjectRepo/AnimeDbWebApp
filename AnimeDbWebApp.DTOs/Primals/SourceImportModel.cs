using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

using static AnimeDbWebApp.Common.ValidationConstants.SourceValidation;

namespace AnimeDbWebApp.DTOs.Primals
{
    public class SourceImportModel
    {
        [Required]
        [JsonProperty("id")]
        public int Id { get; set; }

        [Required]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        [JsonProperty("name")]
        public string Name { get; set; } = null!;
    }
}