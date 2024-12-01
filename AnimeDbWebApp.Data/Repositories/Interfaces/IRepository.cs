using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AnimeDbWebApp.Data.Repositories.Interfaces
{
	public interface IRepository : IDisposable
    {
        public int EntitiesCount<T>(Expression<Func<T, bool>>? predicate = null) where T : class;
        public Task<int> EntitiesCountAsync<T>(Expression<Func<T, bool>>? predicate = null) where T : class;
        public void Add<T>(T entity) where T : class;
        public Task AddAsync<T>(T entity) where T : class;
		public void Remove<T>(T entity) where T : class;
		public bool Any<T>(Expression<Func<T, bool>> predicate) where T : class;
		public Task<bool> AnyAsync<T>(Expression<Func<T, bool>> predicate) where T : class;
		public T? Find<T, TT>(TT id) where T : class;
        public Task<T?> FindAsync<T, TT>(TT id) where T : class;
		public T? FirstOrDefault<T>(Func<T, bool> predicate) where T : class;
        public Task<T?> FirstOrDefaultAsync<T>(Expression<Func<T, bool>> predicate) where T : class;
        public T? FirstWithInclude<T>(Func<T, bool> predicate, string[] includes) where T : class;
        public Task<T?> FirstWithIncludeAsync<T>(Expression<Func<T, bool>> predicate,
            string[] includes) where T : class;
        public ICollection<T> Where<T>(Func<T,bool> predicate) where T : class;
        public Task<ICollection<T>> WhereAsync<T>(Expression<Func<T, bool>> predicate) where T : class;
        public ICollection<T> WhereWithInclude<T>(Func<T, bool> predicate, string[] includes) where T : class;
        public Task<ICollection<T>> WhereWithIncludeAsync<T>(Expression<Func<T, bool>> predicate,
            string[] includes) where T : class;
		public ICollection<T> All<T>() where T : class;
        public Task<ICollection<T>> AllAsync<T>() where T : class;
        public Tuple<int, ICollection<T>> TakePage<T>(int items, int page,
			Expression<Func<T, bool>>? predicate = null, params string[] includes) where T : class;
		public Task<Tuple<int, ICollection<T>>> TakePageAsync<T>(int items, int page,
            Expression<Func<T, bool>>? predicate = null, params string[] includes)
            where T : class;
        public int SaveChanges<T>() where T : class;
        public Task<int> SaveChangesAsync();
    }
}