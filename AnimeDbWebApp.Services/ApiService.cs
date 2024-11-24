using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Services.Interfaces;

namespace AnimeDbWebApp.Services
{
	public class ApiService(IRepository repository) : IApiService
	{
		private readonly IRepository _repo = repository;

		public async Task<ICollection<T>> GetAdded<T, TU> (int status, Expression<Func<TU, bool>> whereFunc, string[] include)
			where T : class where TU : class
		{
			ICollection<TU> entities = await _repo.WhereWithIncludeAsync(whereFunc, include);
			var viewModel = new List<T>();
			CustomMapper.MapAll(entities, viewModel, "withInner");
			return viewModel;
		}
	}
}