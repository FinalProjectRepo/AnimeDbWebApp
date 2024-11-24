using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

using AnimeDbWebApp.ViewModels.Generic;

namespace AnimeDbWebApp.Services.Interfaces
{
	public interface IAddedService
	{
		public Task<AddedWithCountViewModel<TT>> GetAdded<T, TT, TU>(int page, int itemsPerPage,
			int status, Expression<Func<TU, bool>>? whereFunc)
			where T : class where TT : class where TU : class;

		public Task AddMapping<T, TT>(Guid userId, int id, int status, Expression<Func<T, bool>> Tpredicate,
			Expression<Func<TT, bool>> TTpredicate, Expression<Func<T, bool>> TUserPredicate)
			where T : class where TT : class;

		public Task RemoveMapping<T, TT>(Guid userId, int id, Expression<Func<T, bool>> Tpredicate,
			Expression<Func<T, bool>> TUserPredicate) where T : class where TT : class;
	}
}