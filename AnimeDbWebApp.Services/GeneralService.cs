using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models.BaseModels;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Generic;

namespace AnimeDbWebApp.Services
{
    public class GeneralService(IRepository repository) : IGeneralService
	{
		private readonly IRepository _repo = repository;

		public async Task<GeneralWithCountViewModel<TT>> GetAll<T, TT, TU>
			(string? userId, int page, int itemsPerPage, string search)
			where T : General where TT : class where TU : UserGeneral
		{
			if (page <= 0) page = 1;
			if (itemsPerPage is not (10 or 20 or 50)) itemsPerPage = 50;

			Expression<Func<T, bool>>? whereFunc = null;
			if (!string.IsNullOrEmpty(search)) whereFunc = a => a.Title.Contains(search);
			IEnumerable<T> entities = [];
			int totalPages = 0;
			(totalPages, entities) = await _repo.TakePageAsync<T>(itemsPerPage, page, whereFunc, "Type");

			var viewModel = new GeneralWithCountViewModel<TT>()
			{
				TotalPages = totalPages,
				Page = page > totalPages ? totalPages : page,
				ItemsPerPage = itemsPerPage,
				Search = search
			};

			var dict = new Dictionary<int, int>();
			bool userParse = Guid.TryParse(userId, out Guid userGuid);
			if (userParse) await FillDictionary<TU>(userGuid, dict, a => a.UserId == userGuid);
			viewModel.UserAddedEntities = dict;
			CustomMapper.MapAll(entities, viewModel.Entities, true);
			return viewModel;
		}

		public async Task<TT> GetModel<T, TT, TU>(string? userId, int id, string[] includes)
			where T : General where TT : GeneralDetailsViewModel where TU : UserGeneral
		{
			Expression<Func<T, bool>> firstFunc = a => a.Id == id;
			var entity = await _repo.FirstWithIncludeAsync<T>(firstFunc, includes);
			var viewModel = Activator.CreateInstance(typeof(TT)) as TT;
			if (entity == null) return viewModel!;

			var dict = new Dictionary<int, int>();
			bool userParse = Guid.TryParse(userId, out Guid userGuid);
			if (userParse) await FillDictionary<TU>(userGuid, dict, a => a.UserId == userGuid);
			viewModel!.AddedEntity = dict;

			CustomMapper.MapViews(entity, viewModel!);
			return viewModel!;
		}

		private async Task FillDictionary<TU>(Guid userGuid, Dictionary<int, int> addedEntities, Expression<Func<TU, bool>> filter)
			where TU : UserGeneral
		{
			var userMangas = await _repo.WhereAsync<TU>(filter);
			var props = typeof(TU).GetProperties();
			var entityId = props.FirstOrDefault(p => p.Name == "Id" && p.Name != "UserId");
			var status = props.FirstOrDefault(p => p.Name.Contains("Status"));
			if (status == null || entityId == null) return;
			foreach (var entity in userMangas)
			{
				int.TryParse($"{status.GetValue(entity)}", out int statusValue);
				int.TryParse($"{status.GetValue(entity)}", out int id);
				addedEntities[statusValue] = id;
			}
		}
	}
}