using System.ComponentModel.DataAnnotations;

using static AnimeDbWebApp.Common.ValidationConstants.TypeValidation;

namespace AnimeDbWebApp.DTOs
{
    public class TypeImportModel
    {
        [Required]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;
    }
}