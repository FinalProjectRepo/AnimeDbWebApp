using AnimeDbWebApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AnimeDbWebApp.Data.Configurations
{
    public class MangaAuthorConfiguration : IEntityTypeConfiguration<MangaAuthor>
    {
        public void Configure(EntityTypeBuilder<MangaAuthor> builder)
        {
            builder.HasKey(am => new { am.AuthorId, am.MangaId });

            builder.HasOne(am => am.Author)
                .WithMany(a => a.MangasAuthors)
                .HasForeignKey(am => am.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(am => am.Manga)
                .WithMany(m => m.MangasAuthors)
                .HasForeignKey(am => am.MangaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}