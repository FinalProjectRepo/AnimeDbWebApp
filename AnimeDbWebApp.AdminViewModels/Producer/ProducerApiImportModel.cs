using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

using static AnimeDbWebApp.Common.ValidationConstants.ProducerValidations;

namespace AnimeDbWebApp.AdminViewModels.Producer
{
    public class ProducerApiImportModel
    {
        [MaxLength(MaxUrlLength)]
        [AllowNull]
        public string? Url { get; set; }

        [Required]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        [MaxLength(MaxJpNameLength)]
        [AllowNull]
        public string? JpName { get; set; } = null!;

        [MaxLength(MaxImgUrlLength)]
        [AllowNull]
        public string? ImgUrl { get; set; }

        public string? Established { get; set; }

        public string? About { get; set; }
    }
}