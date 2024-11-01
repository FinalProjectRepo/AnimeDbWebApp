using AnimeDbWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimeDbWebApp.Data.Configurations
{
    public class AnimeRelationConfiguration : IEntityTypeConfiguration<AnimeRelation>
    {
        public void Configure(EntityTypeBuilder<AnimeRelation> builder)
        {
            builder.HasKey(al => new { al.AnimeId, al.RelationId });

            builder.HasOne(al => al.Anime)
                .WithMany(ar => ar.AnimesRelations)
                .HasForeignKey(al => al.AnimeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(al => al.Relation)
                .WithMany(p => p.AnimesRelations)
                .HasForeignKey(al => al.RelationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
