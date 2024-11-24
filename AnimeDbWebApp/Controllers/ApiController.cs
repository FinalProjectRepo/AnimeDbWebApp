using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

using System.Security.Claims;
using System.Threading.Tasks;
using System.Collections.Generic;

using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Added;
using AnimeDbWebApp.ViewModels.Generic;

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
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			string[] includes = [ "Anime", "Anime.Type" ];
			var model = await _service.GetAdded<AddedAnimeViewModel, AppUserAnime>(userId!, status, includes);
			return Ok(model);	
		}

		[HttpGet]
		[Route("[controller]/[action]")]
		[ProducesResponseType(typeof(ICollection<AddedMangaViewModel>), StatusCodes.Status200OK)]
		public async Task<ActionResult<ICollection<AddedMangaViewModel>>> GetUserMangaList (int status = 0)
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			string[] includes = [ "Manga", "Manga.Type" ];
			var model = await _service.GetAdded<AddedMangaViewModel, AppUserManga>(userId!, status, includes);
			return Ok(model);
		}
	}
}