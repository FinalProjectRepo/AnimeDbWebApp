using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using AnimeDbWebApp.Models;

namespace AnimeDbWebApp.Data.Configurations
{
    public class AnimeLicensorConfiguration : IEntityTypeConfiguration<AnimeLicensor>
    {
        public void Configure(EntityTypeBuilder<AnimeLicensor> builder)
        {
            builder.HasKey(al => new { al.AnimeId, al.LicensorId });

            builder.HasOne(al => al.Anime)
                .WithMany(a => a.AnimesLicensors)
                .HasForeignKey(al => al.AnimeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(al => al.Licensor)
                .WithMany(p => p.AnimesLicensors)
                .HasForeignKey(al => al.LicensorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}