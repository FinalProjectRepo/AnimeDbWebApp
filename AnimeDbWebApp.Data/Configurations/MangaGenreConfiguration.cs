using AnimeDbWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimeDbWebApp.Data.Configurations
{
    public class MangaGenreConfiguration : IEntityTypeConfiguration<MangaGenre>
    {
        public void Configure(EntityTypeBuilder<MangaGenre> builder)
        {
            builder.HasKey(al => new { al.MangaId, al.GenreId });

            builder.HasOne(al => al.Manga)
                .WithMany(ar => ar.Genres)
                .HasForeignKey(al => al.MangaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(al => al.Genre)
                .WithMany(p => p.Mangas)
                .HasForeignKey(al => al.GenreId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
