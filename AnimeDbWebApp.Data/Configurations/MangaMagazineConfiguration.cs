using AnimeDbWebApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AnimeDbWebApp.Data.Configurations
{
    public class MangaMagazineConfiguration : IEntityTypeConfiguration<MangaMagazine>
    {
        public void Configure(EntityTypeBuilder<MangaMagazine> builder)
        {
            builder.HasKey(mm => new { mm.MangaId, mm.MagazineId });

            builder.HasOne(mm => mm.Manga)
                .WithMany(m => m.MangasMagazines)
                .HasForeignKey(mm => mm.MangaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(mm => mm.Magazine)
                .WithMany(m => m.MangasMagazines)
                .HasForeignKey(mm => mm.MagazineId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}