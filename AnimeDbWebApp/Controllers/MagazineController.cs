using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Magazine;

namespace AnimeDbWebApp.Controllers
{
	public class MagazineController(IPrimalService service) : Controller
	{
		private readonly IPrimalService _service = service;

		[HttpGet]
		public async Task<IActionResult> Index(int page, int itemsPerPage, string search)
		{
			var model = await _service.GetAll<Magazine, MagazineViewModel>(page, itemsPerPage, search);
			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			string[] includes =
			{
				"MangasMagazines", "MangasMagazines.Manga"
			};
			var model = await _service.GetModel<Magazine, MagazineDetailsViewModel>(id, includes);
			return View(model);
		}
	}
}
