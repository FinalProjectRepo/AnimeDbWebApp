using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Threading.Tasks;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models.BaseModels;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Generic;
using AnimeDbWebApp.Models.Enums;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

namespace AnimeDbWebApp.Services
{
	public class AddedService(IRepository repository) : IAddedService
	{
		private readonly IRepository _repo = repository;

		public async Task<AddedWithCountViewModel<TT>> GetAdded<T, TT, TU>
			(string userId, int page, int itemsPerPage, int status)
			where T : class where TT : class where TU : UserGeneral
		{
			if (page <= 0) page = 1;
			if (itemsPerPage is not (10 or 20 or 50)) itemsPerPage = 50;

			bool userParse = Guid.TryParse(userId, out Guid userGuid);
			Expression<Func<TU, bool>>? whereFunc = null;
			if (status < MinRangeWatchingStatus || status > MaxRangeWatchingStatus) whereFunc = a => a.UserId == userGuid;
			else whereFunc = a => (a.UserId == userGuid && a.WatchingStatus == (WatchingStatus)status);

			IEnumerable<TU> entities = [];
			int totalPages = 0;
			(totalPages, entities) = await _repo.TakePageAsync<TU>(itemsPerPage, page, whereFunc, nameof(T));

			var viewModel = new AddedWithCountViewModel<TT>()
			{
				TotalPages = totalPages,
				Page = page > totalPages ? totalPages : page,
				ItemsPerPage = itemsPerPage,
				Status = status,
			};

			CustomMapper.MapAll(entities, viewModel.Entities, true);
			return viewModel;
		}
	}
}