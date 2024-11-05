using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AnimeDbWebApp.DTOs.Mappings
{
    public class AnimeLicensorImportModel
    {
        [Required]
        [JsonProperty("firstId")]
        public int AnimeId { get; set; }

        [Required]
        [JsonProperty("secondId")]
        public int LicensorId { get; set; }
    }
}