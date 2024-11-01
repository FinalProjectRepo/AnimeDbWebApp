using AnimeDbWebApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AnimeDbWebApp.Data.Configurations
{
    public class AnimeMangaConfiguration : IEntityTypeConfiguration<AnimeManga>
    {
        public void Configure(EntityTypeBuilder<AnimeManga> builder)
        {
            builder.HasKey(al => new { al.AnimeId, al.MangaId });

            builder.HasOne(al => al.Anime)
                .WithMany(ar => ar.Adaptations)
                .HasForeignKey(al => al.AnimeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(al => al.Manga)
                .WithMany(p => p.Adaptations)
                .HasForeignKey(al => al.MangaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}