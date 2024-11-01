using AnimeDbWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimeDbWebApp.Data.Configurations
{
    public class AnimeProducerConfiguration : IEntityTypeConfiguration<AnimeProducer>
    {
        public void Configure(EntityTypeBuilder<AnimeProducer> builder)
        {
            builder.HasKey(al => new { al.AnimeId, al.ProducerId });

            builder.HasOne(al => al.Anime)
                .WithMany(ar => ar.AnimesProducers)
                .HasForeignKey(al => al.AnimeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(al => al.Producer)
                .WithMany(p => p.AnimesProducers)
                .HasForeignKey(al => al.ProducerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
