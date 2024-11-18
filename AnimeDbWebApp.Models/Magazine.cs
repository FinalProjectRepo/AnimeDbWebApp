using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static AnimeDbWebApp.Common.ValidationConstants.MagazineValidations;
using AnimeDbWebApp.Models.BaseModels;

namespace AnimeDbWebApp.Models
{
    public class Magazine : Primal
    {
        [Comment("Url link to mal site")]
        [MaxLength(MaxUrlLength)]
        public string? Url { get; set; }

        [Required]
        [Comment("Magazine name")]
        [MaxLength(MaxNameLength)]
        public new string Name { get; set; } = null!;

        public ICollection<MangaMagazine> MangasMagazines { get; set; } = [];
    }
}