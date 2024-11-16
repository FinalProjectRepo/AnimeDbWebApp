using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AnimeDbWebApp.Data.Repositories.Interfaces
{
    public interface IRepository : IDisposable
    {
        public int EntitiesCount<T>() where T : class;
        public Task<int> EntitiesCountAsync<T>() where T : class;
        public void Add<T>(T entity) where T : class;
        public Task AddAsync<T>(T entity) where T : class;
        public void Remove<T>(T entity) where T : class;
        public T? Find<T, TT>(TT id) where T : class;
        public Task<T?> FindAsync<T, TT>(TT id) where T : class;
		public T? FirstOrDefault<T>(Func<T, bool> predicate) where T : class;
        public Task<T?> FirstOrDefaultAsync<T>(Expression<Func<T, bool>> predicate) where T : class;
        public T? FirstWithInclude<T>(Func<T, bool> predicate, params Expression<Func<T, object>>[] includes) where T : class;
        public Task<T?> FirstWithIncludeAsync<T>(Expression<Func<T, bool>> predicate,
            Expression<Func<T, object>>[] includes) where T : class;
        public IEnumerable<T> Where<T>(Func<T,bool> predicate) where T : class;
        public Task<IEnumerable<T>> WhereAsync<T>(Expression<Func<T, bool>> predicate) where T : class;
        public IEnumerable<T> All<T>() where T : class;
        public Task<IEnumerable<T>> AllAsync<T>() where T : class;
        public Tuple<int, IEnumerable<T>> TakePage<T>(int items, int page,
			Expression<Func<T, bool>>? predicate = null, params Expression<Func<T, object>>[] includes) where T : class;
		public Task<Tuple<int, IEnumerable<T>>> TakePageAsync<T>(int items, int page,
            Expression<Func<T, bool>>? predicate = null, params Expression<Func<T, object>>[] includes)
            where T : class;
        public int SaveChanges<T>() where T : class;
        public Task<int> SaveChangesAsync<T>() where T : class;
    }
}