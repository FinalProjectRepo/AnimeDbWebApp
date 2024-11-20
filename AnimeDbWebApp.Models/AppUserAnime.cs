using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

using AnimeDbWebApp.Models.Enums;
using AnimeDbWebApp.Models.BaseModels;

namespace AnimeDbWebApp.Models
{
    public class AppUserAnime : UserGeneral
    {
        [Required]
        [Comment("Unique identifier of anime")]
        public new int Id { get; set; }
        [ForeignKey(nameof(Id))]
        public Anime Anime { get; set; } = null!;
        

        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; } = null!;
    }
}