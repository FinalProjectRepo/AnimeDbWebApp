using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;
using System.Linq.Expressions;
using System;

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
			Expression<Func<Magazine, bool>>? searchFunc = null;
			if (!string.IsNullOrEmpty(search)) searchFunc = a => a.Name.Contains(search);
			var model = await _service.GetAll<Magazine, MagazineViewModel>(page, itemsPerPage, searchFunc);
			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			Expression<Func<Magazine, bool>> firstFunc = a => a.Id == id;
			string[] includes =
			{
				"MangasMagazines", "MangasMagazines.Manga"
			};
			var model = await _service.GetModel<Magazine, MagazineDetailsViewModel>(id, firstFunc, includes);
			return View(model);
		}
	}
}