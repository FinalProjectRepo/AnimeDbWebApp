using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AnimeDbWebApp.DTOs.Mappings
{
    public class MangaMagazineImportModel
    {
        [Required]
        [JsonProperty("firstId")]
        public int MangaId { get; set; }

        [Required]
        [JsonProperty("secondId")]
        public int MagazineId { get; set; }
    }
}