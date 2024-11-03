using AnimeDbWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimeDbWebApp.Data.Configurations
{
    public class MangaRelationConfiruration : IEntityTypeConfiguration<MangaRelation>
    {
        public void Configure(EntityTypeBuilder<MangaRelation> builder)
        {
            builder.HasKey(al => new { al.MangaId, al.RelationId });

            builder.HasOne(al => al.Manga)
                .WithMany(ar => ar.MangaRalations)
                .HasForeignKey(al => al.MangaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}