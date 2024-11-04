using System.ComponentModel.DataAnnotations;

using static AnimeDbWebApp.Common.ValidationConstants.RelationValidations;

namespace AnimeDbWebApp.DTOs.Mappings
{
    public class MappingRelationImportModel
    {
        [Required]
        public int AnimeId { get; set; }

        [Required]
        public int LicensorId { get; set; }

        [Required]
        [MinLength(MinRelationTypeLength)]
        [MaxLength(MaxRelationTypeLength)]
        public string RelationType { get; set; } = null!;
    }
}