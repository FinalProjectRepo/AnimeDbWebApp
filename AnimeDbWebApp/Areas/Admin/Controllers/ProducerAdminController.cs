using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

using AnimeDbWebApp.AdminViewModels.Producer;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Areas.Admin.Controllers
{
	[Authorize(Roles = RoleAdmin)]
	[Area("Admin")]
	public class ProducerAdminController(IAdminService service) : Controller
	{
		private readonly IAdminService _service = service;

		[HttpGet]
		public IActionResult Add()
		{
			ProducerImportViewModel model = new ProducerImportViewModel();
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Add(ProducerImportViewModel model)
		{
			if (!ModelState.IsValid) return View(model);
			ViewData["AddProducer"] = "true";
			await _service.AddEntity<Producer, ProducerImportViewModel>(model);
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Remove(int id)
		{
			await _service.RemoveEntity<Producer>(a => a.Id == id);
			return RedirectToAction("Index", "HomeAdmin");
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			var model = await _service.GetEditEntity<Producer, ProducerImportViewModel>(a => a.Id == id);
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(ProducerImportViewModel model)
		{
			if (!ModelState.IsValid) return View(model);
			await _service.EditEntity<Producer, ProducerImportViewModel>(model, a => a.Id == model.Id);
			return RedirectToAction("Index", "HomeAdmin");
		}
	}
}