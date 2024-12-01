using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using AnimeDbWebApp.Models;

namespace AnimeDbWebApp.Data.Configurations
{
    public class MangaRelationConfiruration : IEntityTypeConfiguration<MangaRelation>
    {
        public void Configure(EntityTypeBuilder<MangaRelation> builder)
        {
            builder.HasKey(mr => new { mr.MangaId, mr.RelationId });

            builder.HasOne(mr => mr.Manga)
                .WithMany(m => m.MangaRelations)
                .HasForeignKey(mr => mr.MangaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}