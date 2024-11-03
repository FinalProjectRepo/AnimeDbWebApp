using Microsoft.EntityFrameworkCore;
using AnimeDbWebApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimeDbWebApp.Data.Configurations
{
    public class AnimeGenreConfiguration : IEntityTypeConfiguration<AnimeGenre>
    {
        public void Configure(EntityTypeBuilder<AnimeGenre> builder)
        {
            builder.HasKey(al => new { al.AnimeId, al.GenreId });

            builder.HasOne(al => al.Anime)
                .WithMany(ar => ar.Genres)
                .HasForeignKey(al => al.AnimeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(al => al.Genre)
                .WithMany(p => p.Animes)
                .HasForeignKey(al => al.GenreId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
