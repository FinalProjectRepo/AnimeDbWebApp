using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;

using AnimeDbWebApp.AdminViewModels.SelectEnum;

namespace AnimeDbWebApp.Services.Interfaces
{
	public interface IAdminService
    {
		public Task<ICollection<BasicClassForList>> GetListEntities<T>() where T : class;
		public Task AddEntity<T, TT>(TT model)
			where T : class where TT : class;
		public Task RemoveEntity<T>(Expression<Func<T, bool>> predicate) where T : class;
		public Task<TT?> GetEditEntity<T, TT>(Expression<Func<T, bool>> predicate) 
			where T : class where TT : class;
		public Task EditEntity<T, TT>(TT model, Expression<Func<T, bool>> predicate)
			where T : class where TT : class;
		public Task AddMapping<T>(int firstId, int secondId, Expression<Func<T, bool>> predicate)
			where T : class;
		public Task RemoveMapping<T>(Expression<Func<T, bool>> predicate) where T : class;
		public Task AddOrEditRelation<T>(int firstId, int secondId, string relation,
			Expression<Func<T, bool>> predicate) where T : class;
	}
}