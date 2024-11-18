using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System;
using System.Reflection;

using AnimeDbWebApp.Data;
using AnimeDbWebApp.Data.Repositories;
using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Extensions;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services;

namespace AnimeDbWebApp
{
	public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("SqlServer") 
                ?? throw new InvalidOperationException("Connection string not found.");

            builder.Services.AddDbContext<AnimeDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();


            builder.Services.AddIdentity<AppUser, IdentityRole<Guid>>(
                options => options.SignIn.RequireConfirmedAccount = false
                )
                .AddEntityFrameworkStores<AnimeDbContext>()
				.AddRoles<IdentityRole<Guid>>()
				.AddSignInManager<SignInManager<AppUser>>()
				.AddUserManager<UserManager<AppUser>>();

			builder.Services.ConfigureApplicationCookie(cfg =>
			{
				cfg.LoginPath = "/Identity/Account/Login";
			});

            builder.Services.AddScoped<IRepository, Repository>();
            builder.Services.RegisterServices(Assembly.GetAssembly(typeof(HomeService))!);

			builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}