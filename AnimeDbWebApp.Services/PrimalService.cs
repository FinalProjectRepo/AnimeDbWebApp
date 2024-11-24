using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Generic;

namespace AnimeDbWebApp.Services
{
	public class PrimalService(IRepository repository) : IPrimalService
	{
		private readonly IRepository _repo = repository;

		public async Task<PrimalWithCountViewModel<TT>> GetAll<T, TT>(int page, int itemsPerPage, 
			Expression<Func<T, bool>>? searchFunc) where T : class where TT : class
		{
			if (page <= 0) page = 1;
			if (itemsPerPage is not (10 or 20 or 50)) itemsPerPage = 50;

			ICollection<T> entities = [];
			int totalPages = 0;
			(totalPages, entities) = await _repo.TakePageAsync<T>(itemsPerPage, page, searchFunc);

			var viewModel = new PrimalWithCountViewModel<TT>();
			viewModel!.TotalPages = totalPages;
			viewModel.Page = page > totalPages ? totalPages : page;
			viewModel.ItemsPerPage = itemsPerPage;

			CustomMapper.MapAll(entities, viewModel.Entities, "view");
			return viewModel;
		}

		public async Task<TT> GetModel<T, TT>(int id, Expression<Func<T, bool>> firstFunc, string[] includes)
			where T : class where TT : class
		{
			var entity = await _repo.FirstWithIncludeAsync<T>(firstFunc, includes);
			var model = Activator.CreateInstance(typeof(TT)) as TT;
			if (entity == null) return model!;

			var inputProps = typeof(T).GetProperties();
			var outputProps = typeof(TT).GetProperties();
			CustomMapper.MapViews(entity, model!, inputProps, outputProps);
			return model!;
		}
	}
}