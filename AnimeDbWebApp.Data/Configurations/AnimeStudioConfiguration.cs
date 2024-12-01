using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using AnimeDbWebApp.Models;

namespace AnimeDbWebApp.Data.Configurations
{
    public class AnimeStudioConfiguration : IEntityTypeConfiguration<AnimeStudio>
    {
        public void Configure(EntityTypeBuilder<AnimeStudio> builder)
        {
            builder.HasKey(ast => new { ast.AnimeId, ast.StudioId });

            builder.HasOne(ast => ast.Anime)
                .WithMany(a => a.AnimesStudios)
                .HasForeignKey(ast => ast.AnimeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ast => ast.Studio)
                .WithMany(s => s.AnimesStudios)
                .HasForeignKey(ast => ast.StudioId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}