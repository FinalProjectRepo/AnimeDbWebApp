using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

using System.Security.Claims;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

using AnimeDbWebApp.Models;
using AnimeDbWebApp.Models.Enums;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Added;
using AnimeDbWebApp.ViewModels.Generic;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

namespace AnimeDbWebApp.Controllers
{
	[Route("[controller]/")]
	[ApiController]
	[Authorize]
	public class ApiController(IApiService service) : ControllerBase
	{
		private readonly IApiService _service = service;

		[HttpGet("[action]")]
		[ProducesResponseType(typeof(ICollection<AddedAnimeViewModel>), StatusCodes.Status200OK)]
		public async Task<ActionResult<ICollection<AddedAnimeViewModel>>> GetUserAnimeList (int status = 0)
		{
			var userId = User.FindFirstValueGuid(ClaimTypes.NameIdentifier);
			string[] includes = [ "Anime", "Anime.Type" ];
			Expression<Func<AppUserAnime, bool>>? whereFunc = null;
			if (status < MinRangeWatchingStatus || status > MaxRangeWatchingStatus) whereFunc = ua => ua.UserId == userId;
			else whereFunc = ua => (ua.UserId == userId && ua.WatchingStatus == (WatchingStatus)status);
			var model = await _service.GetAdded<AddedAnimeViewModel, AppUserAnime>(status, whereFunc, includes);
			return Ok(model);	
		}

		[HttpGet("[action]")]
		[ProducesResponseType(typeof(ICollection<AddedMangaViewModel>), StatusCodes.Status200OK)]
		public async Task<ActionResult<ICollection<AddedMangaViewModel>>> GetUserMangaList (int status = 0)
		{
			var userId = User.FindFirstValueGuid(ClaimTypes.NameIdentifier);
			string[] includes = [ "Manga", "Manga.Type" ];
			Expression<Func<AppUserManga, bool>>? whereFunc = null;
			if (status < MinRangeWatchingStatus || status > MaxRangeWatchingStatus) whereFunc = um => um.UserId == userId;
			else whereFunc = um => (um.UserId == userId && um.WatchingStatus == (WatchingStatus)status);
			var model = await _service.GetAdded<AddedMangaViewModel, AppUserManga>(status, whereFunc, includes);
			return Ok(model);
		}

		[HttpGet("[action]")]
		[ProducesResponseType(typeof(ICollection<AddedMangaViewModel>), StatusCodes.Status200OK)]
		public async Task<IActionResult> AddAnime(int id, int status)
		{
			var userId = User.FindFirstValueGuid(ClaimTypes.NameIdentifier);
			Expression<Func<AppUserAnime, bool>> Tpredicate = ua => ua.UserId == userId && ua.Id == id;
			Expression<Func<Anime, bool>> TTpredicate = a => a.Id == id;
			Expression<Func<AppUserAnime, bool>> TUserPredicate = ua => ua.UserId == userId;
			await _service.AddMapping<AppUserAnime, Anime>(userId!, id, status, Tpredicate, TTpredicate, TUserPredicate);
			return Ok();
		}

		[HttpGet("[action]")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<IActionResult> AddManga(int id, int status)
		{
			var userId = User.FindFirstValueGuid(ClaimTypes.NameIdentifier);
			Expression<Func<AppUserManga, bool>> Tpredicate = um => um.UserId == userId && um.Id == id;
			Expression<Func<Manga, bool>> TTpredicate = m => m.Id == id;
			Expression<Func<AppUserManga, bool>> TUserPredicate = um => um.UserId == userId;
			await _service.AddMapping<AppUserManga, Manga>(userId!, id, status, Tpredicate, TTpredicate, TUserPredicate);
			return Ok();
		}
	}
}