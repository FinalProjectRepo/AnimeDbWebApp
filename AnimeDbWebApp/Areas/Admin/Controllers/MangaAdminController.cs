using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

using AnimeDbWebApp.AdminViewModels.Anime;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.AdminViewModels.Manga;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Areas.Admin.Controllers
{
	[Authorize(Roles = RoleAdmin)]
	[Area("Admin")]
	public class MangaAdminController(IAdminService service) : Controller
	{
		private readonly IAdminService _service = service;

		[HttpGet]
		public async Task<IActionResult> Add()
		{
			MangaImportViewModel model = new MangaImportViewModel();
			model.TypeList = await _service.GetListEntities<TypeForManga>();
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Add(MangaImportViewModel model)
		{
			if (!ModelState.IsValid)
			{
				model.TypeList = await _service.GetListEntities<TypeForManga>();
				return View(model);
			}
			ViewData["AddManga"] = "true";
			await _service.AddEntity<Manga, MangaImportViewModel>(model);
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Remove(int id)
		{
			await _service.RemoveEntity<Manga>(a => a.Id == id);
			return RedirectToAction("Index", "HomeAdmin");
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			var model = await _service.GetEditEntity<Manga, MangaImportViewModel>(a => a.Id == id);
			if (model == null) return View(model);
			model.TypeList = await _service.GetListEntities<TypeForManga>();
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(MangaImportViewModel model)
		{
			if (!ModelState.IsValid)
			{
				model.TypeList = await _service.GetListEntities<TypeForManga>();
				return View(model);
			}
			await _service.EditEntity<Manga, MangaImportViewModel>(model, a => a.Id == model.Id);
			return RedirectToAction("Index", "HomeAdmin");
		}
	}
}