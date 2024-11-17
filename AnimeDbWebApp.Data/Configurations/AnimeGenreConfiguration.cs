using Microsoft.EntityFrameworkCore;
using AnimeDbWebApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimeDbWebApp.Data.Configurations
{
    public class AnimeGenreConfiguration : IEntityTypeConfiguration<AnimeGenre>
    {
        public void Configure(EntityTypeBuilder<AnimeGenre> builder)
        {
            builder.HasKey(ag => new { ag.AnimeId, ag.GenreId });

            builder.HasOne(ag => ag.Anime)
                .WithMany(a => a.Genres)
                .HasForeignKey(ag => ag.AnimeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ag => ag.Genre)
                .WithMany(g => g.Animes)
                .HasForeignKey(ag => ag.GenreId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}