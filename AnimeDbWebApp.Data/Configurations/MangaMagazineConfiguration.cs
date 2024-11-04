using AnimeDbWebApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AnimeDbWebApp.Data.Configurations
{
    public class MangaMagazineConfiguration : IEntityTypeConfiguration<MangaMagazine>
    {
        public void Configure(EntityTypeBuilder<MangaMagazine> builder)
        {
            builder.HasKey(al => new { al.MangaId, al.MagazineId });

            builder.HasOne(al => al.Manga)
                .WithMany(ar => ar.MangasMagazines)
                .HasForeignKey(al => al.MangaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(al => al.Magazine)
                .WithMany(p => p.MangasMagazines)
                .HasForeignKey(al => al.MagazineId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}