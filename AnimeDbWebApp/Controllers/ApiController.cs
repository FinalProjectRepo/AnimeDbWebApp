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
	[Route("[controller]")]
	[ApiController]
	[Authorize]
	public class ApiController(IApiService service) : ControllerBase
	{
		private readonly IApiService _service = service;

		[HttpGet]
		[Route("[controller]/[action]")]
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

		[HttpGet]
		[Route("[controller]/[action]")]
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
	}
}