using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using AnimeDbWebApp.Models;

namespace AnimeDbWebApp.Data.Configurations
{
    public class AnimeRelationConfiguration : IEntityTypeConfiguration<AnimeRelation>
    {
        public void Configure(EntityTypeBuilder<AnimeRelation> builder)
        {
            builder.HasKey(ar => new { ar.AnimeId, ar.RelationId });

            builder.HasOne(ar => ar.Anime)
                .WithMany(a => a.AnimesRelations)
                .HasForeignKey(ar => ar.AnimeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}