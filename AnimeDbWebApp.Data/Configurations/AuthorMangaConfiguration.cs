using AnimeDbWebApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AnimeDbWebApp.Data.Configurations
{
    public class AuthorMangaConfiguration : IEntityTypeConfiguration<AuthorManga>
    {
        public void Configure(EntityTypeBuilder<AuthorManga> builder)
        {
            builder.HasKey(al => new { al.AuthorId, al.MangaId });

            builder.HasOne(al => al.Author)
                .WithMany(ar => ar.AuthorsMangas)
                .HasForeignKey(al => al.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(al => al.Manga)
                .WithMany(p => p.AuthorsMangas)
                .HasForeignKey(al => al.MangaId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}