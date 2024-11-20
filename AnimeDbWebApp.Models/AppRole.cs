using Microsoft.AspNetCore.Identity;
using System;

namespace AnimeDbWebApp.Models
{
	public class AppRole : IdentityRole<Guid>
    {
        public AppRole(string name) 
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}