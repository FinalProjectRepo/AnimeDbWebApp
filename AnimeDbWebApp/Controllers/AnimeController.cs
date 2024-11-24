using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System;

using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Anime;

namespace AnimeDbWebApp.Controllers
{
    public class AnimeController(IGeneralService service) : Controller
    {
        private readonly IGeneralService _service = service;

        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int itemsPerPage = 50, string search = "")
        {
            var userId = User?.FindFirstValueGuid(ClaimTypes.NameIdentifier);
			Expression<Func<Anime, bool>>? whereSearch = null;
			if (!string.IsNullOrEmpty(search)) whereSearch = a => a.Title.Contains(search);

            Expression<Func<AppUserAnime, bool>>? whereUser = null;
            if (userId != null) whereUser = ua => ua.UserId == userId;

			var model = await _service.GetAll<Anime, AnimeViewModel, AppUserAnime>(page, itemsPerPage, whereSearch, whereUser);
            model.Search = search;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
		{
			var userId = User?.FindFirstValueGuid(ClaimTypes.NameIdentifier);
			Expression<Func<Anime, bool>> firstFunc = a => a.Id == id;
			Expression<Func<AppUserAnime, bool>>? whereUser = null;
			if (userId != null) whereUser = ua => ua.UserId == userId && ua.Id == id;
			string[] includes =
			{
				"Type","Source", "Genres", "Genres.Genre", "AnimesProducers", "AnimesProducers.Producer",
				"AnimesLicensors", "AnimesLicensors.Licensor", "AnimesStudios", "AnimesStudios.Studio",
				 "AnimesRelations", "AnimesRelations.Relation", "MangaAdaptations", "MangaAdaptations.Manga"
			};
			var model = await _service.GetModel<Anime, AnimeDetailsViewModel, AppUserAnime>(id, firstFunc, whereUser, includes);
            return View(model);
        }
    }
}