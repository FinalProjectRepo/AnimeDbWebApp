using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static AnimeDbWebApp.Common.ValidationConstants.SourceValidation;

namespace AnimeDbWebApp.Models
{
    public class Source
    {
        [Key]
        [Comment("Unique Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Source name")]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        public ICollection<Anime> Animes { get; set; } = [];
    }
}