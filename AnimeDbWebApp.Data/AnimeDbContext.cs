using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

using System;

using AnimeDbWebApp.Models;
using System.Reflection;
using AnimeDbWebApp.Data.Extensions;

namespace AnimeDbWebApp.Data
{
    public class AnimeDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
		public AnimeDbContext() { }

		public DbSet<Anime> Animes { get; set; } = null!;
		public DbSet<AnimeLicensor> AnimesLicensors { get; set; } = null!;
		public DbSet<AnimeManga> AnimesMangas { get; set; } = null!;
		public DbSet<AnimeProducer> AnimesProducers { get; set; } = null!;
		public DbSet<AnimeRelation> AnimesRelations { get; set; } = null!;
		public DbSet<AnimeStudio> AnimesStudios { get; set; } = null!;
		public DbSet<Author> Authors { get; set; } = null!;
		public DbSet<GenreForAnime> GenresForAnimes { get; set; } = null!;
		public DbSet<GenreForManga> GenresForMangas { get; set; } = null!;
		public DbSet<Manga> Mangas { get; set; } = null!;
		public DbSet<MangaRelation> MangasRelations { get; set; } = null!;
		public DbSet<Producer> Producers { get; set; } = null!;
		public DbSet<Models.Type> Types { get; set; } = null!;
		public DbSet<AnimeGenre> AnimesGenres { get; set; } = null!;
		public DbSet<MangaGenre> MangasGenres { get; set; } = null!;

		public AnimeDbContext(DbContextOptions<AnimeDbContext> options)
            : base(options) { }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			builder.Seed();
		}
	}
}