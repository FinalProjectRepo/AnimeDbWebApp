using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

using AnimeDbWebApp.ViewModels.ExtraForUser;
using AnimeDbWebApp.ViewModels.Generic;

namespace AnimeDbWebApp.Services.Interfaces
{
	public interface IGeneralService
	{
		public Task<GeneralWithCountViewModel<TT>> GetAll<T, TT, TU>(int page, int itemsPerPage,
			Expression<Func<T, bool>>? whereSearch, Expression<Func<TU, bool>>? whereUser)
			where T : class where TT : class where TU : class;
		public Task<TT> GetModel<T, TT, TU>(int id, Expression<Func<T, bool>> firstFunc,
			Expression<Func<TU, bool>>? whereUser, string[] includes)
			where T : class where TT : InheritedForWatchingStatus where TU : class;
	}
}