using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

using static AnimeDbWebApp.Common.ValidationConstants.RelationValidations;

namespace AnimeDbWebApp.DTOs.Mappings
{
    public class MangaRelationImportModel
    {
        [Required]
        [JsonProperty("firstId")]
        public int MangaId { get; set; }

        [Required]
        [JsonProperty("secondId")]
        public int RelationId { get; set; }

        [Required]
        [MaxLength(MaxRelationTypeLength)]
        [JsonProperty("relationType")]
        public string RelationType { get; set; } = null!;
    }
}