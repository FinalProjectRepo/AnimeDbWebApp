using AnimeDbWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AnimeDbWebApp.Controllers
{
	public class MangaController(IMangaService service) : Controller
	{
		private readonly IMangaService _service = service;

		[HttpGet]
		public async Task<IActionResult> Index(int page = 1, int itemsPerPage = 50, string search = "")
		{
			var userId = User?.FindFirstValue(ClaimTypes.NameIdentifier);
			var model = await _service.GetAll(userId, page, itemsPerPage, search);
			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Details(int mangaId)
		{
			var model = await _service.GetAnime(mangaId);
			return View(model);
		}
	}
}
