using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using System;
using System.Linq;
using System.Reflection;

using AnimeDbWebApp.Data;
using AnimeDbWebApp.Data.Repositories;
using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Models;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class BuilderServicesExtensions
    {
		public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
		{
			var connectionString = configuration.GetConnectionString("SqlServer")
				?? throw new InvalidOperationException("Connection string not found.");

			services.AddDbContext<AnimeDbContext>(options =>
				options.UseSqlServer(connectionString));
			services.AddDatabaseDeveloperPageExceptionFilter();

			return services;
		}

		public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddIdentity<AppUser, AppRole>(
				options => options.IdentityOptions(configuration))
			.AddEntityFrameworkStores<AnimeDbContext>()
			.AddRoles<AppRole>()
			.AddRoleManager<RoleManager<AppRole>>()
			.AddSignInManager<SignInManager<AppUser>>()
			.AddUserManager<UserManager<AppUser>>();

			services.ConfigureApplicationCookie(options => options.CookieOptions(configuration));
			return services;
		}

		public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration, Assembly? assembly)
		{
			if(assembly == null) throw new InvalidOperationException("Custom service HomeService not found.");

			services.AddScoped<IRepository, Repository>();

			var appServices = assembly.GetTypes().Where(t => !t.IsAbstract && t.IsVisible);
			var interfaces = assembly.GetTypes().Where(t => t.IsAbstract);

			foreach (var service in appServices)
			{
				var currInterface = interfaces
					.FirstOrDefault(t => t.Name.Equals(InterfacesPrefix + service.Name,
						StringComparison.InvariantCultureIgnoreCase));

				if (currInterface != null) services.AddScoped(currInterface, service);
			}
			return services;
		}

		private static void IdentityOptions(this IdentityOptions options, IConfiguration configuration)
		{
			options.SignIn.RequireConfirmedAccount = configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");

			options.Password.RequireNonAlphanumeric = configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
			options.Password.RequireDigit = configuration.GetValue<bool>("Identity:Password:RequireDigit");
			options.Password.RequireLowercase = configuration.GetValue<bool>("Identity:Password:RequireLowercase");
			options.Password.RequireUppercase = configuration.GetValue<bool>("Identity:Password:RequireUppercase");
			options.Password.RequiredLength = configuration.GetValue<int>("Identity:Password:RequiredLength");

			options.User.RequireUniqueEmail = configuration.GetValue<bool>("Identity:User:RequireUniqueEmail");
			options.User.AllowedUserNameCharacters = configuration.GetValue<string>("Identity:User:AllowedUserNameCharacters")!;

			options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(
				configuration.GetValue<int>("Identity:Lockout:DefaultLockoutTimeSpan"));
			options.Lockout.MaxFailedAccessAttempts = configuration.GetValue<int>("Identity:Lockout:MaxFailedAccessAttempts");
		}
		private static void CookieOptions(this CookieAuthenticationOptions options, IConfiguration configuration)
		{
			options.Cookie.Name = configuration.GetValue<string>("Identity:Cookie:Name");
			options.Cookie.HttpOnly = configuration.GetValue<bool>("Identity:Cookie:HttpOnly");
			options.ExpireTimeSpan = TimeSpan.FromMinutes(
				configuration.GetValue<int>("Identity:Cookie:ExpireTimeSpan"));
			options.LoginPath = configuration.GetValue<string>("Identity:Cookie:LoginPath");
			options.SlidingExpiration = configuration.GetValue<bool>("Identity:Cookie:SlidingExpiration");
		}
	}
}