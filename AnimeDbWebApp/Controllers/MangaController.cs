using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System;

using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Manga;

namespace AnimeDbWebApp.Controllers
{
	public class MangaController(IGeneralService service) : Controller
	{
		private readonly IGeneralService _service = service;

		[HttpGet]
		public async Task<IActionResult> Index(int page = 1, int itemsPerPage = 50, string search = "")
		{
			var userId = User?.FindFirstValueGuid(ClaimTypes.NameIdentifier);
			Expression<Func<Manga, bool>>? whereSearch = null;
			if (!string.IsNullOrEmpty(search)) whereSearch = m => m.Title.Contains(search);

			Expression<Func<AppUserManga, bool>>? whereUser = null;
			if (userId != null) whereUser = um => um.UserId == userId;

			var model = await _service.GetAll<Manga, MangaViewModel, AppUserManga>(page, itemsPerPage, whereSearch, whereUser);
			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			var userId = User?.FindFirstValueGuid(ClaimTypes.NameIdentifier);
			Expression<Func<Manga, bool>> firstFunc = m => m.Id == id;
			Expression<Func<AppUserManga, bool>>? whereUser = null;
			if (userId != null) whereUser = um => um.UserId == userId && um.Id == id;
			string[] includes =
			{
				"Type", "Genres", "Genres.Genre", "MangasAuthors", "MangasAuthors.Author",
				 "MangaRelations", "MangaRelations.Relation", "AnimeAdaptations", "AnimeAdaptations.Anime",
				 "MangasMagazines", "MangasMagazines.Magazine"
			};
			var model = await _service.GetModel<Manga, MangaDetailsViewModel, AppUserManga>(id, firstFunc, whereUser, includes);
			return View(model);
		}
	}
}