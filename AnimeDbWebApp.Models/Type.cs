using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static AnimeDbWebApp.Common.ValidationConstants.TypeValidation;

namespace AnimeDbWebApp.Models
{
    public class Type
    {
        [Key]
        [Comment("Unique Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Type name")]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        public ICollection<Anime> Animes { get; set; } = [];
        public ICollection<Manga> Mangas { get; set; } = [];
    }
}