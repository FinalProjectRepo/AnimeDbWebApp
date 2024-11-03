using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

using static AnimeDbWebApp.Common.ValidationConstants.TypeValidation;

namespace AnimeDbWebApp.DTOs
{
    public class TypeImportModel
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