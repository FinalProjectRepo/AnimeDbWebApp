using Microsoft.AspNetCore.Identity;

using System;

namespace AnimeDbWebApp.Models
{
	public class AppUser : IdentityUser<Guid>
    {
        public AppUser()
        {
            Id = Guid.NewGuid();
        }
    }
}