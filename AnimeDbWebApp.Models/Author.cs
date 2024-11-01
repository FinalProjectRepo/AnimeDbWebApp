using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static AnimeDbWebApp.Common.ValidationConstants.AuthorValidations;

namespace AnimeDbWebApp.Models
{
    public class Author
    {
        [Key]
        [Comment("Unique identifier that equals mal_id")]
        public int Id { get; set; }

        [Comment("Url link to mal site")]
        [MaxLength(MaxUrlLength)]
        public string? Url { get; set; }

        [Comment("Person website")]
        [MaxLength(MaxWebsiteUrlLength)]
        public string? Website { get; set; }

        [Comment("Person poster url")]
        [MaxLength(MaxPosterUrlLength)]
        public string? PosterUrl { get; set; }

        [Required]
        [Comment("Anime title")]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        [Comment("Anime title in english translated")]
        [MaxLength(MaxGivenNameLength)]
        public string? GivenName { get; set; } = null!;

        [Comment("Anime title in japanese characters")]
        [MaxLength(MaxFamilyNameLength)]
        public string? FamilyName { get; set; } = null!;

        [Required]
        [Comment("Date of birth")]
        [Column(TypeName = "DATETIME2")]
        public DateTime Birthdate { get; set; }

        [Comment("Aditional information about person")]
        [MaxLength(MaxAboutLength)]
        public string? About { get; set; }

        public ICollection<AuthorManga> AuthorsMangas { get; set; } = [];
    }
}