using AnimeDbWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimeDbWebApp.Data.Configurations
{
    public class AnimeStudioConfiguration : IEntityTypeConfiguration<AnimeStudio>
    {
        public void Configure(EntityTypeBuilder<AnimeStudio> builder)
        {
            builder.HasKey(al => new { al.AnimeId, al.StudioId });

            builder.HasOne(al => al.Anime)
                .WithMany(ar => ar.AnimesStudios)
                .HasForeignKey(al => al.AnimeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(al => al.Studio)
                .WithMany(p => p.AnimesStudios)
                .HasForeignKey(al => al.StudioId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
