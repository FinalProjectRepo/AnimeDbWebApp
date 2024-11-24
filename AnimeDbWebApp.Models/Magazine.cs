using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static AnimeDbWebApp.Common.ValidationConstants.MagazineValidations;

namespace AnimeDbWebApp.Models
{
    public class Magazine
	{
		[Key]
		[Comment("Unique identifier that equals mal_id")]
		public int Id { get; set; }

		[Comment("Url link to mal site")]
        [MaxLength(MaxUrlLength)]
        public string? Url { get; set; }

        [Required]
        [Comment("Magazine name")]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        public ICollection<MangaMagazine> MangasMagazines { get; set; } = [];
    }
}