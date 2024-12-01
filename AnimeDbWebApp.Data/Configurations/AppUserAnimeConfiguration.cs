using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using AnimeDbWebApp.Models;

namespace AnimeDbWebApp.Data.Configurations
{
    public class AppUserAnimeConfiguration : IEntityTypeConfiguration<AppUserAnime>
    {
        public void Configure(EntityTypeBuilder<AppUserAnime> builder)
        {
            builder.HasKey(au => new { au.Id, au.UserId });

            builder.HasOne(au => au.Anime)
                .WithMany(a => a.AppUsers)
                .HasForeignKey(au => au.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(au => au.AppUser)
                .WithMany(u => u.Animes)
                .HasForeignKey(au => au.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}