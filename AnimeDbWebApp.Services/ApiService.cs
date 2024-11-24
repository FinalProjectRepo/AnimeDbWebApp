using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models.BaseModels;
using AnimeDbWebApp.Models.Enums;
using AnimeDbWebApp.Services.Interfaces;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

namespace AnimeDbWebApp.Services
{
	public class ApiService(IRepository repository) : IApiService
	{
		private readonly IRepository _repo = repository;

		public async Task<ICollection<T>> GetAdded<T, TU> (string userId, int status, string[] include)
			where T : class where TU : UserGeneral
		{
			bool userParse = Guid.TryParse(userId, out Guid userGuid);
			Expression<Func<TU, bool>>? whereFunc = null;
			if (status < MinRangeWatchingStatus || status > MaxRangeWatchingStatus) whereFunc = a => a.UserId == userGuid;
			else whereFunc = a => (a.UserId == userGuid && a.WatchingStatus == (WatchingStatus)status);

			ICollection<TU> entities = await _repo.WhereWithIncludeAsync(whereFunc, include);

			var viewModel = Activator.CreateInstance(typeof(List<T>)) as List<T>;
			CustomMapper.MapAll(entities, viewModel!, "withInner");
			return viewModel!;
		}
	}
}