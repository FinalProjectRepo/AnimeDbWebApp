using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AnimeDbWebApp.DTOs.Mappings
{
    public class AnimeStudioImportModel
    {
        [Required]
        [JsonProperty("firstId")]
        public int AnimeId { get; set; }

        [Required]
        [JsonProperty("secondId")]
        public int StudioId { get; set; }
    }
}