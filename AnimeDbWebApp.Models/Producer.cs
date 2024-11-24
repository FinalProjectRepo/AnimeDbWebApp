using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

using static AnimeDbWebApp.Common.ValidationConstants.ProducerValidations;

namespace AnimeDbWebApp.Models
{
    public class Producer
    {
		[Key]
		[Comment("Unique identifier that equals mal_id")]
		public int Id { get; set; }

		[Comment("Url link to mal site of producer")]
        [MaxLength(MaxUrlLength)]
        public string? Url { get; set; }

        [Required]
        [Comment("English name of the producer")]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        [Comment("Japanese name of the producer")]
        [MaxLength(MaxJpNameLength)]
        public string? JpName { get; set; }

        [Comment("Producer image url")]
        [MaxLength(MaxImgUrlLength)]
        public string? ImgUrl { get; set; }

        [Comment("Date the producer is established")]
        [Column(TypeName = "DATETIME2")]
        public DateTime? Established { get; set; }

        [Comment("Information about producer")]
        public string? About { get; set; }

        public ICollection<AnimeProducer> AnimesProducers { get; set; } = [];
        public ICollection<AnimeLicensor> AnimesLicensors { get; set; } = [];
        public ICollection<AnimeStudio> AnimesStudios { get; set; } = [];
    }
}