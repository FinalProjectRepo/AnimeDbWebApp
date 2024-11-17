using AnimeDbWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimeDbWebApp.Data.Configurations
{
    public class MangaGenreConfiguration : IEntityTypeConfiguration<MangaGenre>
    {
        public void Configure(EntityTypeBuilder<MangaGenre> builder)
        {
            builder.HasKey(mg => new { mg.MangaId, mg.GenreId });

            builder.HasOne(mg => mg.Manga)
                .WithMany(m => m.Genres)
                .HasForeignKey(mg => mg.MangaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(mg => mg.Genre)
                .WithMany(g => g.Mangas)
                .HasForeignKey(mg => mg.GenreId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}