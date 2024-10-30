using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

using System;

using AnimeDbWebApp.Models;

namespace AnimeDbWebApp.Data
{
    public class AnimeDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
		public AnimeDbContext() { }

		public AnimeDbContext(DbContextOptions<AnimeDbContext> options)
            : base(options) { }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
	}
}