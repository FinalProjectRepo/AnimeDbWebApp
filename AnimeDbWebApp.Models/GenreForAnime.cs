﻿using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static AnimeDbWebApp.Common.ValidationConstants.GenreValidations;

namespace AnimeDbWebApp.Models
{
    public class GenreForAnime
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("Genre name")]
        [MaxLength(MinNameLength)]
        public string Name { get; set; } = null!;

        public ICollection<Anime> Animes { get; set; } = [];
    }
}