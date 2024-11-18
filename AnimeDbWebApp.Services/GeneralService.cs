using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models.BaseModels;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels;

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
			IEnumerable<T> mangas = [];
			int totalPages = 0;
			(totalPages, mangas) = await _repo.TakePageAsync<T>(itemsPerPage, page, whereFunc, "Type");

			var viewModel = new GeneralWithCountViewModel<TT>()
			{
				TotalPages = totalPages,
				Page = page > totalPages ? totalPages : page,
				ItemsPerPage = itemsPerPage,
				Search = search
			};

			var dict = new Dictionary<int, int>();
			bool userParse = Guid.TryParse(userId, out Guid userGuid);
			if (userParse)
			{
				var userMangas = await _repo.WhereAsync<TU>(ua => ua.UserId == userGuid);
				var props = typeof(TU).GetProperties();
				var entityId = props.FirstOrDefault(p => p.Name.Contains("Id") && p.Name != "UserId");
				var status = props.FirstOrDefault(p => p.Name.Contains("Status"));
				if (status == null || entityId == null) return viewModel;
				foreach (var entity in userMangas)
				{
					int.TryParse($"{status.GetValue(entity)}", out int statusValue);
					int.TryParse($"{status.GetValue(entity)}", out int id);
					dict[statusValue] = id;
				}
			}

			viewModel.UserAddedEntities = dict;
			CustomMapper.MapAll(mangas, viewModel.Entities, true);
			return viewModel;
		}

		public async Task<TT> GetModel<T, TT>(int id, string[] includes)
			where T : General where TT : class
		{
			Expression<Func<T, bool>> firstFunc = a => a.Id == id;
			var entity = await _repo.FirstWithIncludeAsync<T>(firstFunc, includes);
			var model = Activator.CreateInstance(typeof(TT)) as TT;
			if (entity == null) return model!;

			CustomMapper.MapViews(entity, model!);
			return model!;
		}
	}
}