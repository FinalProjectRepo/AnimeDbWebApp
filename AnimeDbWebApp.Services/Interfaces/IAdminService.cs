using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;

using AnimeDbWebApp.AdminViewModels.SelectEnum;
using AnimeDbWebApp.AdminViewModels.AddGenre;

namespace AnimeDbWebApp.Services.Interfaces
{
	public interface IAdminService
    {
		public Task<ICollection<BasicClassForList>> GetListEntities<T>() where T : class;
		public Task AddEntity<T, TT>(TT model)
			where T : class where TT : class;
		public Task<bool> RemoveEntity<T>(Expression<Func<T, bool>> predicate) where T : class;
		public Task<TT?> GetEditEntity<T, TT>(Expression<Func<T, bool>> predicate) 
			where T : class where TT : class;
		public Task EditEntity<T, TT>(TT model, Expression<Func<T, bool>> predicate)
			where T : class where TT : class;
	}
}