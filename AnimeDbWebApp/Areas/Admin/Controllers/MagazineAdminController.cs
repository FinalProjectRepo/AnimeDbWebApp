using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

using AnimeDbWebApp.AdminViewModels.Magazine;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Areas.Admin.Controllers
{
	[Authorize(Roles = RoleAdmin)]
	[Area("Admin")]
	public class MagazineAdminController(IAdminService service) : Controller
	{
		private readonly IAdminService _service = service;

		[HttpGet]
		public IActionResult Add()
		{
			MagazineImportViewModel model = new MagazineImportViewModel();
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Add(MagazineImportViewModel model)
		{
			if (!ModelState.IsValid) return View(model);
			ViewData["AddMagazine"] = "true";
			await _service.AddEntity<Magazine, MagazineImportViewModel>(model);
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Remove(int id)
		{
			await _service.RemoveEntity<Magazine>(a => a.Id == id);
			return RedirectToAction("Index", "HomeAdmin");
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			var model = await _service.GetEditEntity<Magazine, MagazineImportViewModel>(a => a.Id == id);
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(MagazineImportViewModel model)
		{
			if (!ModelState.IsValid) return View(model);
			await _service.EditEntity<Magazine, MagazineImportViewModel>(model, a => a.Id == model.Id);
			return RedirectToAction("Index", "HomeAdmin");
		}
	}
}