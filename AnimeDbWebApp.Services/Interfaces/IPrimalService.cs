using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

using AnimeDbWebApp.ViewModels.Generic;

namespace AnimeDbWebApp.Services.Interfaces
{
	public interface IPrimalService
	{
		public Task<PrimalWithCountViewModel<TT>> GetAll<T, TT>(int page, int itemsPerPage,
			Expression<Func<T, bool>>? searchFunc) where T : class where TT : class;
		public Task<TT> GetModel<T, TT>(int id, Expression<Func<T, bool>> firstFunc, string[] includes)
			where T : class where TT : class;
	}
}