using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Data;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class AppBuilderServicesExtensions
	{
		public static async void AddRoleToUser(this IServiceProvider provider)
		{
			var userManager = provider.GetService<UserManager<AppUser>>();
			var roleManager = provider.GetService<RoleManager<AppRole>>();

			if (userManager != null && roleManager != null)
			{
				string[] roles = ["Admin", "AnimeWeeb", "MangaWeeb"];
				foreach (var role in roles)
				{
					if (!(await roleManager.RoleExistsAsync(role)))
						await roleManager.CreateAsync(new AppRole(role));
				}

				var admin = await userManager.FindByNameAsync("Admin");
				if (admin != null) await userManager.AddToRoleAsync(admin, "Admin");
				
				var weeb = await userManager.FindByNameAsync("AnimeManiac");
				if (weeb != null)
				{
					await userManager.AddToRoleAsync(weeb, "AnimeWeeb");
					await userManager.AddToRoleAsync(weeb, "MangaWeeb");
				}
			}
		}
	}
}