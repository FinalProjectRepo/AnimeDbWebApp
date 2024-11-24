using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;
using System.Linq.Expressions;
using System;

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
			Expression<Func<Author, bool>>? searchFunc = null;
			if (!string.IsNullOrEmpty(search)) searchFunc = a => a.Name.Contains(search);
			var model = await _service.GetAll<Author, AuthorViewModel>(page, itemsPerPage, searchFunc);
			model.Search = search;
			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			Expression<Func<Author, bool>> firstFunc = a => a.Id == id;
			string[] includes =
			{
				"MangasAuthors", "MangasAuthors.Manga"
			};
			var model = await _service.GetModel<Author, AuthorDetailsViewModel>(id, firstFunc, includes);
			return View(model);
		}
	}
}