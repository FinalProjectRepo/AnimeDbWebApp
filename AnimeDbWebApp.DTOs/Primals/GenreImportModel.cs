using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

using static AnimeDbWebApp.Common.ValidationConstants.GenreValidations;

namespace AnimeDbWebApp.DTOs.Primals
{
    public class GenreImportModel
    {
        [Key]
        [JsonProperty("mal_id")]
        public int Id { get; set; }

        [Required]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        [JsonProperty("name")]
        public string Name { get; set; } = null!;
    }
}