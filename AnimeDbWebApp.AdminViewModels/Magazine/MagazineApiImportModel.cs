using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

using static AnimeDbWebApp.Common.ValidationConstants.MagazineValidations;

namespace AnimeDbWebApp.AdminViewModels.Magazine
{
    public class MagazineApiImportModel
    {
        [MaxLength(MaxUrlLength)]
        [AllowNull]
        public string? Url { get; set; }

        [Required]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;
    }
}