using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

using AnimeDbWebApp.Models.Enums;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;
using AnimeDbWebApp.Models.BaseModels;

namespace AnimeDbWebApp.Models
{
    public class AppUserManga : UserGeneral
    {
        [Required]
        [Comment("Unique identifier of manga")]
        public new int Id { get; set; }
        [ForeignKey(nameof(Id))]
        public Manga Manga { get; set; } = null!;


        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; } = null!;
    }
}