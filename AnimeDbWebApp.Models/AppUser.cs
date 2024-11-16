using Microsoft.AspNetCore.Identity;

using System;
using System.Collections.Generic;

namespace AnimeDbWebApp.Models
{
	public class AppUser : IdentityUser<Guid>
    {
        public AppUser()
        {
            Id = Guid.NewGuid();
        }

        public ICollection<AppUserManga> Mangas { get; set; } = [];
        public ICollection<AppUserAnime> Animes { get; set; } = [];
    }
}