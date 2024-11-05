using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AnimeDbWebApp.DTOs.Mappings
{
    public class AnimeGenreImportModel
    {
        [Required]
        [JsonProperty("firstId")]
        public int AnimeId { get; set; }

        [Required]
        [JsonProperty("secondId")]
        public int GenreId { get; set; }
    }
}