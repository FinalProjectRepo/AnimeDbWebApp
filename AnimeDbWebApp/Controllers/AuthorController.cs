using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

using AnimeDbWebApp.Models;
using AnimeDbWebApp.ViewModels.Author;
using AnimeDbWebApp.Services.Interfaces;

namespace AnimeDbWebApp.Controllers
{
	public class AuthorController(IPrimalService service) : Controller
	{
		private readonly IPrimalService _service = service;

		[HttpGet]
		public async Task<IActionResult> Index(int page, int itemsPerPage, string search)
		{
			var model = await _service.GetAll<Author, AuthorViewModel>(page, itemsPerPage, search);
			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			string[] includes =
			{
				"MangasAuthors", "MangasAuthors.Manga"
			};
			var model = await _service.GetModel<Author, AuthorDetailsViewModel>(id, includes);
			return View(model);
		}
	}
}
