using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

using AnimeDbWebApp.AdminViewModels.Author;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Areas.Admin.Controllers
{
	[Authorize(Roles = RoleAdmin)]
	[Area("Admin")]
	public class AuthorAdminController(IAdminService service) : Controller
	{
		private readonly IAdminService _service = service;

		[HttpGet]
		public IActionResult Add()
		{
			AuthorImportViewModel model = new AuthorImportViewModel();
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Add(AuthorImportViewModel model)
		{
			if (!ModelState.IsValid) return View(model);
			ViewData["AddAuthor"] = "true";
			await _service.AddEntity<Author, AuthorImportViewModel>(model);
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Remove(int id)
		{
			await _service.RemoveEntity<Author>(a => a.Id == id);
			return RedirectToAction("Index", "HomeAdmin");
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			var model = await _service.GetEditEntity<Author, AuthorImportViewModel>(a => a.Id == id);
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(AuthorImportViewModel model)
		{
			if (!ModelState.IsValid) return View(model);
			await _service.EditEntity<Author, AuthorImportViewModel>(model, a => a.Id == model.Id);
			return RedirectToAction("Index", "HomeAdmin");
		}
	}
}