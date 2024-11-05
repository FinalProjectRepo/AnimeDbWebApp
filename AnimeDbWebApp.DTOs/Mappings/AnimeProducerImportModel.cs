using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AnimeDbWebApp.DTOs.Mappings
{
    public class AnimeProducerImportModel
    {
        [Required]
        [JsonProperty("firstId")]
        public int AnimeId { get; set; }

        [Required]
        [JsonProperty("secondId")]
        public int ProducerId { get; set; }
    }
}