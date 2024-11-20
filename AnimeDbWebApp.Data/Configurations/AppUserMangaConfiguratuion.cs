using AnimeDbWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimeDbWebApp.Data.Configurations
{
    public class AppUserMangaConfiguratuion : IEntityTypeConfiguration<AppUserManga>
    {
        public void Configure(EntityTypeBuilder<AppUserManga> builder)
        {
            builder.HasKey(au => new { au.Id, au.UserId });

            builder.HasOne(au => au.Manga)
                .WithMany(m => m.AppUsers)
                .HasForeignKey(au => au.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(au => au.AppUser)
                .WithMany(u => u.Mangas)
                .HasForeignKey(au => au.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}