using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;
using System.Threading.Tasks;

using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Added;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

namespace AnimeDbWebApp.Controllers
{
	[Authorize]
	public class AddedController(IAddedService service) : Controller
	{
		private readonly IAddedService _service = service;

		[HttpGet]
		public async Task<IActionResult> AddedAnime(int page = 1, int itemsPerPage = 50, int status = 0)
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			var model = await _service.GetAdded<Anime, AddedAnimeViewModel, AppUserAnime>
				(userId!, page, itemsPerPage, status, nameof(Anime));
            return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> AddedManga(int page = 1, int itemsPerPage = 50, int status = 0)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = await _service.GetAdded<Manga, AddedMangaViewModel, AppUserManga>
				(userId!, page, itemsPerPage, status, nameof(Manga));
            return View(model);
        }

		[HttpPost]
		public async Task<IActionResult> AddAnime(int id , int status, string returnUrl)
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			await _service.AddEntity<AppUserAnime, Anime>(userId!, id, status);
			return Redirect(returnUrl);
		}

		[HttpPost]
		public async Task<IActionResult> AddManga(int id, int status, string returnUrl)
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			await _service.AddEntity<AppUserManga, Manga>(userId!, id, status);
			return Redirect(returnUrl);
		}
	}
}
	