using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

using AnimeDbWebApp.AdminViewModels.Anime;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Areas.Admin.Controllers
{
	[Authorize(Roles = RoleAdmin)]
	[Area("Admin")]
	public class AnimeAdminController(IAdminService service) : Controller
	{
		private readonly IAdminService _service = service;

		[HttpGet]
		public async Task<IActionResult> Add()
		{
			AnimeImportViewModel model = new AnimeImportViewModel();
			model.TypeList = await _service.GetListEntities<TypeForAnime>();
			model.SourceList = await _service.GetListEntities<Source>();
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Add(AnimeImportViewModel model)
		{
			if (!ModelState.IsValid)
			{
				model.TypeList = await _service.GetListEntities<TypeForAnime>();
				model.SourceList = await _service.GetListEntities<Source>();
				return View(model);
			}
			ViewData["AddAnime"] = "true";
			await _service.AddEntity<Anime, AnimeImportViewModel>(model);
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Remove(int id)
		{
			await _service.RemoveEntity<Anime>(a => a.Id == id);
			return RedirectToAction("Index", "HomeAdmin");
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			var model = await _service.GetEditEntity<Anime, AnimeImportViewModel>(a => a.Id == id);
			if (model == null) return View(model);
			model.TypeList = await _service.GetListEntities<TypeForAnime>();
			model.SourceList = await _service.GetListEntities<Source>();
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(AnimeImportViewModel model)
		{
			if (!ModelState.IsValid)
			{
				model.TypeList = await _service.GetListEntities<TypeForAnime>();
				model.SourceList = await _service.GetListEntities<Source>();
				return View(model);
			}
			await _service.EditEntity<Anime, AnimeImportViewModel>(model, a => a.Id == model.Id);
			return RedirectToAction("Index", "HomeAdmin");
		}
	}
}