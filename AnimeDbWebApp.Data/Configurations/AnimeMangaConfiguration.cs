﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using AnimeDbWebApp.Models;

namespace AnimeDbWebApp.Data.Configurations
{
    public class AnimeMangaConfiguration : IEntityTypeConfiguration<AnimeManga>
    {
        public void Configure(EntityTypeBuilder<AnimeManga> builder)
        {
            builder.HasKey(am => new { am.AnimeId, am.MangaId });

            builder.HasOne(am => am.Anime)
                .WithMany(a => a.MangaAdaptations)
                .HasForeignKey(am => am.AnimeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(am => am.Manga)
                .WithMany(m => m.AnimeAdaptations)
                .HasForeignKey(am => am.MangaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}