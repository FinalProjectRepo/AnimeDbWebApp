using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

using static AnimeDbWebApp.Common.ValidationConstants.ProducerValidations;

namespace AnimeDbWebApp.DTOs
{
    public class ProducerImportModel
    {
        [MaxLength(MaxUrlLength)]
        [AllowNull]
        public string? Url { get; set; }

        [Required]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MinLength(MinJpNameLength)]
        [MaxLength(MaxJpNameLength)]
        public string JpName { get; set; } = null!;

        [MaxLength(MaxImgUrlLength)]
        [AllowNull]
        public string? ImgUrl { get; set; }

        public string? Established { get; set; }

        [MaxLength(MaxAboutLength)]
        [AllowNull]
        public string? About { get; set; }
    }
}