using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

using static AnimeDbWebApp.Common.ValidationConstants.ProducerValidations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimeDbWebApp.Models
{
    public class Producer
    {
        [Key]
        [Comment("Unique Identifier")]
        public int Id { get; set; }

        [Comment("Url link to mal site of producer")]
        [MaxLength(MaxUrlLength)]
        public string? Url { get; set; }

        [Required]
        [Comment("English name of the studio")]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        [Required]
        [Comment("Japanese name of the studio")]
        [MaxLength(MaxJpNameLength)]
        public string JpName { get; set; } = null!;

        [Comment("Anime poster url")]
        [MaxLength(MaxImgUrlLength)]
        public string? ImgUrl { get; set; }

        [Comment("Date the studio is established")]
        [Column(TypeName = "DATETIME2")]
        public DateTime Established { get; set; }

        [Comment("Information about producer")]
        [MaxLength(MaxAboutLength)]
        public string? About { get; set; }

        public ICollection<AnimeProducer> AnimesProducers { get; set; } = [];
        public ICollection<AnimeLicensor> AnimesLicensors { get; set; } = [];
        public ICollection<AnimeStudio> AnimesStudios { get; set; } = [];
    }
}