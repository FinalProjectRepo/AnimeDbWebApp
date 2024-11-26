using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.Models;
using static AnimeDbWebApp.Common.GeneralConstants;
using AnimeDbWebApp.ViewModels.Added;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using AnimeDbWebApp.AdminViewModels.Mapping;

namespace AnimeDbWebApp.Areas.Admin.Controllers
{
	[Route("[Area]/[controller]/")]
	[Authorize(Roles = RoleAdmin)]
	[Area("Admin")]
	[ApiController]
	public class MappingAdminController(IAdminService service) : ControllerBase
	{
		private readonly IAdminService _service = service;

		[HttpPost("[action]")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> Add([FromBody] SimpleMapping mapping)
		{
			if (mapping.First == 1)
			{
				switch (mapping.Second)
				{
					case 2: await _service.AddMapping<AnimeManga>(mapping.FirstId, mapping.SecondId,
						am => am.AnimeId == mapping.FirstId && am.MangaId == mapping.SecondId); break;
					case 3: await _service.AddMapping<AnimeGenre>(mapping.FirstId, mapping.SecondId,
						ag => ag.AnimeId == mapping.FirstId && ag.GenreId == mapping.SecondId); break;
					case 4: await _service.AddMapping<AnimeProducer>(mapping.FirstId, mapping.SecondId,
						ap => ap.AnimeId == mapping.FirstId && ap.ProducerId == mapping.SecondId); break;
					case 5: await _service.AddMapping<AnimeStudio>(mapping.FirstId, mapping.SecondId,
						ast => ast.AnimeId == mapping.FirstId && ast.StudioId == mapping.SecondId); break;
					case 6: await _service.AddMapping<AnimeLicensor>(mapping.FirstId, mapping.SecondId,
						al => al.AnimeId == mapping.FirstId && al.LicensorId == mapping.SecondId); break;
					default: return BadRequest();
				}
			}
			else if (mapping.First == 2)
			{
				switch (mapping.Second)
				{
					case 1:
					await _service.AddMapping<AnimeManga>(mapping.SecondId, mapping.FirstId,
							am => am.MangaId == mapping.FirstId && am.AnimeId == mapping.SecondId); break;
					case 3:
						await _service.AddMapping<MangaGenre>(mapping.FirstId, mapping.SecondId,
						mg => mg.MangaId == mapping.FirstId && mg.GenreId == mapping.SecondId); break;
					case 7:
						await _service.AddMapping<MangaAuthor>(mapping.FirstId, mapping.SecondId,
						ma => ma.MangaId == mapping.FirstId && ma.AuthorId == mapping.SecondId); break;
					case 8:
						await _service.AddMapping<MangaMagazine>(mapping.FirstId, mapping.SecondId,
						mm => mm.MangaId == mapping.FirstId && mm.MagazineId == mapping.SecondId); break;
					default: return BadRequest();
				}
			}
			else return BadRequest();
			return Ok();
		}

		[HttpPost("[action]")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> Remove([FromBody] SimpleMapping mapping)
		{
			if (mapping.First == 1)
			{
				switch (mapping.Second)
				{
					case 2:
						await _service.RemoveMapping<AnimeManga>(
							am => am.AnimeId == mapping.FirstId && am.MangaId == mapping.SecondId); break;
					case 3:
						await _service.RemoveMapping<AnimeGenre>(
							ag => ag.AnimeId == mapping.FirstId && ag.GenreId == mapping.SecondId); break;
					case 4:
						await _service.RemoveMapping<AnimeProducer>(
							ap => ap.AnimeId == mapping.FirstId && ap.ProducerId == mapping.SecondId); break;
					case 5:
						await _service.RemoveMapping<AnimeStudio>(
						ast => ast.AnimeId == mapping.FirstId && ast.StudioId == mapping.SecondId); break;
					case 6:
						await _service.RemoveMapping<AnimeLicensor>(
						al => al.AnimeId == mapping.FirstId && al.LicensorId == mapping.SecondId); break;
					default: return BadRequest();
				}
			}
			else if (mapping.First == 2)
			{
				switch (mapping.Second)
				{
					case 1:
						await _service.RemoveMapping<AnimeManga>(
								am => am.MangaId == mapping.FirstId && am.AnimeId == mapping.SecondId); break;
					case 3:
						await _service.RemoveMapping<MangaGenre>(
						mg => mg.MangaId == mapping.FirstId && mg.GenreId == mapping.SecondId); break;
					case 7:
						await _service.RemoveMapping<MangaAuthor>(
						ma => ma.MangaId == mapping.FirstId && ma.AuthorId == mapping.SecondId); break;
					case 8:
						await _service.RemoveMapping<MangaMagazine>(
						mm => mm.MangaId == mapping.FirstId && mm.MagazineId == mapping.SecondId); break;
					default: return BadRequest();
				}
			}
			else return BadRequest();
			return Ok();
		}

		[HttpPost("[action]")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> AddOrEditRelation([FromBody] RelationMapping mapping)
		{
			if (mapping.First == 1) await _service.AddOrEditRelation<AnimeRelation>(mapping.FirstId, mapping.SecondId, mapping.Relation,
				ar => ar.AnimeId == mapping.FirstId && ar.RelationId == mapping.SecondId);
			else if (mapping.First == 2) await _service.AddOrEditRelation<MangaRelation>(mapping.FirstId, mapping.SecondId, mapping.Relation,
				mr => mr.MangaId == mapping.FirstId && mr.RelationId == mapping.SecondId);
			else return BadRequest();
			return Ok();
		}

		[HttpPost("[action]")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> RemoveRelation([FromBody] RelationMapping mapping)
		{
			if (mapping.First == 1) await _service.RemoveEntity<AnimeRelation>(
				ar => ar.AnimeId == mapping.FirstId && ar.RelationId == mapping.SecondId);
			else if (mapping.First == 2) await _service.RemoveEntity<MangaRelation>(
				mr => mr.MangaId == mapping.FirstId && mr.RelationId == mapping.SecondId);
			else return BadRequest();
			return Ok();
		}
	}
}