using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static AnimeDbWebApp.Common.ValidationConstants.AuthorValidations;
using AnimeDbWebApp.Models.BaseModels;

namespace AnimeDbWebApp.Models
{
    public class Author : Primal
    {
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
        [Comment("Author name")]
        [MaxLength(MaxNameLength)]
        public new string Name { get; set; } = null!;

        [Comment("Author given name")]
        [MaxLength(MaxGivenNameLength)]
        public string? GivenName { get; set; }

        [Comment("Author family name")]
        [MaxLength(MaxFamilyNameLength)]
        public string? FamilyName { get; set; }

        [Comment("Author birthdate")]
        [Column(TypeName = "DATETIME2")]
        public DateTime? Birthdate { get; set; }

        [Comment("Aditional information about author")]
        public string? About { get; set; }

        public ICollection<MangaAuthor> MangasAuthors { get; set; } = [];
    }
}