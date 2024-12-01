using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models.Enums;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.ExtraForUser;
using AnimeDbWebApp.ViewModels.Generic;

namespace AnimeDbWebApp.Services
{
	public class GeneralService(IRepository repository) : IGeneralService
	{
		private readonly IRepository _repo = repository;

		public async Task<GeneralWithCountViewModel<TT>> GetAll<T, TT, TU> (int page, int itemsPerPage,
			Expression<Func<T, bool>>? whereSearch, Expression<Func<TU, bool>>? whereUser)
			where T : class where TT : class where TU : class
		{
			if (page <= 0) page = 1;
			if (itemsPerPage is not (10 or 20 or 50)) itemsPerPage = 50;
			ICollection<T> entities = [];
			int totalPages = 0;
			(totalPages, entities) = await _repo.TakePageAsync<T>(itemsPerPage, page, whereSearch, "Type");

			var viewModel = new GeneralWithCountViewModel<TT>()
			{
				TotalPages = totalPages,
				Page = page > totalPages ? totalPages : page,
				ItemsPerPage = itemsPerPage,
			};

			var dict = new Dictionary<int, int>();
			if(whereUser != null) await FillDictionary<TU>(dict, whereUser);
			viewModel.UserAdded = dict;
			CustomMapper.MapAll(entities, viewModel.Entities, "view");
			return viewModel;
		}

		public async Task<TT> GetModel<T, TT, TU>(int id, Expression<Func<T, bool>> firstFunc,
			Expression<Func<TU, bool>>? whereUser, string[] includes)
			where T : class where TT : InheritedForWatchingStatus where TU : class
		{
			var entity = await _repo.FirstWithIncludeAsync<T>(firstFunc, includes);
			var viewModel = Activator.CreateInstance(typeof(TT)) as TT;
			if (entity == null) return viewModel!;			

			var inputProps = typeof(T).GetProperties();
			var outputProps = typeof(TT).GetProperties();
			CustomMapper.MapViews(entity, viewModel!, inputProps, outputProps);

            var dict = new Dictionary<int, int>();
            if(whereUser != null) await FillDictionary<TU>(dict, whereUser);
			viewModel!.UserAdded = dict;
            return viewModel!;
		}

		private async Task FillDictionary<TU>(Dictionary<int, int> addedEntities, Expression<Func<TU, bool>> filter)
			where TU : class
		{
			var userMangas = await _repo.WhereAsync<TU>(filter);
			var props = typeof(TU).GetProperties();
			var entityId = props.FirstOrDefault(p => p.Name == "Id");
			var status = props.FirstOrDefault(p => p.Name.Contains("Status"));
			if (status == null || entityId == null) throw new ArgumentException("Properties in user entity mapping doesn't match", typeof(TU).Name);
			foreach (var entity in userMangas)
			{
				Enum.TryParse($"{status.GetValue(entity)}", out WatchingStatus statusValue);
				int.TryParse($"{entityId.GetValue(entity)}", out int id);
				addedEntities[id] = (int)statusValue;
			}
		}
	}
}