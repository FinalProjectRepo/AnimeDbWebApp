using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

using static AnimeDbWebApp.Common.ValidationConstants.ProducerValidations;

namespace AnimeDbWebApp.Models
{
    public class Producer
    {
        [Key]
        [Comment("Unique Identifier")]
        public int Id { get; set; }

        [Comment("Url link to mal site of producer")]
        [StringLength(MaxUrlLength)]
        public string? Url { get; set; }

        [Required]
        [Comment("English name of the studio")]
        [StringLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        [Required]
        [Comment("Japanese name of the studio")]
        [StringLength(MaxJpNameLength)]
        public string JpName { get; set; } = null!;

        [Comment("Anime poster url")]
        [StringLength(MaxImgUrlLength)]
        public string? ImgUrl { get; set; }

        [Comment("Date the studio is established")]
        public DateTime Established { get; set; }

        [Comment("Information about producer")]
        [StringLength(MaxAboutLength)]
        public string? About { get; set; }

        public ICollection<AnimeProducer> AnimesProducers { get; set; } = [];
        public ICollection<AnimeLicensor> AnimesLicensors { get; set; } = [];
        public ICollection<AnimeStudio> AnimesStudios { get; set; } = [];
    }
}