using System.ComponentModel.DataAnnotations;

namespace AnimeDbWebApp.DTOs.Mappings
{
    public class MappingImportModel
    {
        [Required]
        public int AnimeId { get; set; }

        [Required]
        public int LicensorId { get; set; }
    }
}