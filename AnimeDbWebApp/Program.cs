using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System.Reflection;

using AnimeDbWebApp.Services;
using Microsoft.Net.Http.Headers;

namespace AnimeDbWebApp
{
	public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDatabase(builder.Configuration);
            builder.Services.AddApplicationIdentity(builder.Configuration);
            builder.Services.AddApplicationServices(builder.Configuration, Assembly.GetAssembly(typeof(HomeService)));

			builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
				app.UseMigrationsEndPoint();
			}
            else
            {
                app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
            }

			app.UseStatusCodePagesWithReExecute("/Home/Status", "?statusCode={0}");

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

			app.MapControllerRoute(
				name: "Area",
				pattern: "{area:exists}/{controller=HomeAdmin}/{action=Index}/{id?}");

			app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

			app.MapRazorPages();

			using (var scope = app.Services.CreateScope())
            {
                scope.ServiceProvider.AddRoleToUser().Wait();
            };

			app.Run();
        }
    }
}