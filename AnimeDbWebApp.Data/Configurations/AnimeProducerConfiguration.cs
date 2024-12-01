using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using AnimeDbWebApp.Models;

namespace AnimeDbWebApp.Data.Configurations
{
    public class AnimeProducerConfiguration : IEntityTypeConfiguration<AnimeProducer>
    {
        public void Configure(EntityTypeBuilder<AnimeProducer> builder)
        {
            builder.HasKey(ap => new { ap.AnimeId, ap.ProducerId });

            builder.HasOne(ap => ap.Anime)
                .WithMany(a => a.AnimesProducers)
                .HasForeignKey(ap => ap.AnimeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ap => ap.Producer)
                .WithMany(p => p.AnimesProducers)
                .HasForeignKey(al => al.ProducerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}