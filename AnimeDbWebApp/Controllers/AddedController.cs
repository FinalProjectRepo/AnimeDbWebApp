using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Added;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AnimeDbWebApp.Controllers
{
	[Authorize]
	public class AddedController(IAddedService service) : Controller
	{
		private readonly IAddedService _service = service;

		public async Task<IActionResult> AddedAnime(int page = 1, int itemsPerPage = 50, int status = 0)
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			var model = await _service.GetAdded<Anime, AddedAnimeViewModel, AppUserAnime>
				(userId!, page, itemsPerPage, status, nameof(Anime));
            return View(model);
		}

        public async Task<IActionResult> AddedManga(int page = 1, int itemsPerPage = 50, int status = 0)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = await _service.GetAdded<Manga, AddedMangaViewModel, AppUserManga>
				(userId!, page, itemsPerPage, status, nameof(Manga));
            return View(model);
        }
    }
}
