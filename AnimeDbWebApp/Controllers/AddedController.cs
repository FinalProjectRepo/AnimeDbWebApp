using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Threading.Tasks;

using AnimeDbWebApp.Models;
using AnimeDbWebApp.Models.Enums;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Added;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

namespace AnimeDbWebApp.Controllers
{
	[Authorize]
	public class AddedController(IAddedService service) : Controller
	{
		private readonly IAddedService _service = service;

		[HttpGet]
		public async Task<IActionResult> AddedAnime(int page = 1, int itemsPerPage = 50, int status = 0)
		{
			var userId = User.FindFirstValueGuid(ClaimTypes.NameIdentifier);
			Expression<Func<AppUserAnime, bool>>? whereFunc = null;
			if (status < MinRangeWatchingStatus || status > MaxRangeWatchingStatus) whereFunc = ua => ua.UserId == userId;
			else whereFunc = ua => (ua.UserId == userId && ua.WatchingStatus == (WatchingStatus)status);

			var model = await _service.GetAdded<Anime, AddedAnimeViewModel, AppUserAnime>
				(page, itemsPerPage, status, whereFunc);
            return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> AddedManga(int page = 1, int itemsPerPage = 50, int status = 0)
        {
            var userId = User.FindFirstValueGuid(ClaimTypes.NameIdentifier);
			Expression<Func<AppUserManga, bool>>? whereFunc = null;
			if (status < MinRangeWatchingStatus || status > MaxRangeWatchingStatus) whereFunc = um => um.UserId == userId;
			else whereFunc = um => (um.UserId == userId && um.WatchingStatus == (WatchingStatus)status);

			var model = await _service.GetAdded<Manga, AddedMangaViewModel, AppUserManga>
				(page, itemsPerPage, status, whereFunc);
            return View(model);
        }

		[HttpPost]
		public async Task<IActionResult> AddAnime(int id , int status, string returnUrl)
		{
			var userId = User.FindFirstValueGuid(ClaimTypes.NameIdentifier);
			Expression<Func<AppUserAnime, bool>> Tpredicate = ua => ua.UserId == userId && ua.Id == id;
			Expression<Func<Anime, bool>> TTpredicate = a => a.Id == id;
			Expression<Func<AppUserAnime, bool>> TUserPredicate = ua => ua.UserId == userId;
			await _service.AddMapping<AppUserAnime, Anime>(userId!, id, status, Tpredicate, TTpredicate, TUserPredicate);
			return Redirect(returnUrl);
		}

		[HttpPost]
		public async Task<IActionResult> AddManga(int id, int status, string returnUrl)
		{
			var userId = User.FindFirstValueGuid(ClaimTypes.NameIdentifier);
			Expression<Func<AppUserManga, bool>> Tpredicate = um => um.UserId == userId && um.Id == id;
			Expression<Func<Manga, bool>> TTpredicate = m => m.Id == id;
			Expression<Func<AppUserManga, bool>> TUserPredicate = um => um.UserId == userId;
			await _service.AddMapping<AppUserManga, Manga>(userId!, id, status, Tpredicate, TTpredicate, TUserPredicate);
			return Redirect(returnUrl);
		}

		[HttpPost]
		public async Task<IActionResult> RemoveAnime(int id, string returnUrl)
		{
			var userId = User.FindFirstValueGuid(ClaimTypes.NameIdentifier);
			Expression<Func<AppUserAnime, bool>> Tpredicate = um => um.UserId == userId && um.Id == id;
			Expression<Func<AppUserAnime, bool>> TUserPredicate = um => um.UserId == userId;
			await _service.RemoveMapping<AppUserAnime, Anime>(userId, id, Tpredicate, TUserPredicate);
			return Redirect(returnUrl);
		}

		[HttpPost]
		public async Task<IActionResult> RemoveManga(int id, string returnUrl)
		{
			var userId = User.FindFirstValueGuid(ClaimTypes.NameIdentifier);
			Expression<Func<AppUserManga, bool>> Tpredicate = um => um.UserId == userId && um.Id == id;
			Expression<Func<AppUserManga, bool>> TUserPredicate = um => um.UserId == userId;
			await _service.RemoveMapping<AppUserManga, Manga>(userId, id, Tpredicate, TUserPredicate);
			return Redirect(returnUrl);
		}
	}
}	