using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Threading.Tasks;

using AnimeDbWebApp.Models;
using AnimeDbWebApp.Data;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class AppBuilderServicesExtensions
	{
		public static async Task<IServiceProvider> AddRoleToUser(this IServiceProvider provider)
		{
			var userManager = provider.GetService<UserManager<AppUser>>();
			var roleManager = provider.GetService<RoleManager<AppRole>>();

			if (userManager != null && roleManager != null)
			{
				string[] roles = [RoleAdmin, RoleAnimeWeeb, RoleMangaWeeb];
				foreach (var role in roles)
				{
					if (!(await roleManager.RoleExistsAsync(role)))
						await roleManager.CreateAsync(new AppRole(role));
				}

				var admin = await userManager.FindByNameAsync(AdminUser);
				if (admin != null) await userManager.AddToRoleAsync(admin, RoleAdmin);
				
				var weeb = await userManager.FindByNameAsync(WeebUser);
				if (weeb != null)
				{
					await userManager.AddToRoleAsync(weeb, RoleAnimeWeeb);
					await userManager.AddToRoleAsync(weeb, RoleMangaWeeb);
				}
			}

			return provider;
		}
	}
}