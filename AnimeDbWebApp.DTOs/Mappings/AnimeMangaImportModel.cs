using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AnimeDbWebApp.DTOs.Mappings
{
    public class AnimeMangaImportModel
    {
        [Required]
        [JsonProperty("firstId")]
        public int AnimeId { get; set; }

        [Required]
        [JsonProperty("secondId")]
        public int MangaId { get; set; }
    }
}