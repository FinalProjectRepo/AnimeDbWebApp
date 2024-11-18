using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;
using System.Threading.Tasks;

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
			var userId = User?.FindFirstValue(ClaimTypes.NameIdentifier);
			var model = await _service.GetAll<Manga, MangaViewModel, AppUserManga>(userId, page, itemsPerPage, search);
			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			string[] includes =
			{
				"Type", "Genres", "Genres.Genre", "MangasAuthors", "MangasAuthors.Author",
				 "MangaRelations", "MangaRelations.Relation", "AnimeAdaptations", "AnimeAdaptations.Anime",
				 "MangasMagazines", "MangasMagazines.Magazine"
			};
			var model = await _service.GetModel<Manga, MangaDetailsViewModel>(id, includes);
			return View(model);
		}
	}
}