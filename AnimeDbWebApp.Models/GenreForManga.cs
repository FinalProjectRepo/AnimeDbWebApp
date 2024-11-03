using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static AnimeDbWebApp.Common.ValidationConstants.GenreValidations;

namespace AnimeDbWebApp.Models
{
    public class GenreForManga
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("Genre name")]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        public ICollection<MangaGenre> Mangas { get; set; } = [];
    }
}