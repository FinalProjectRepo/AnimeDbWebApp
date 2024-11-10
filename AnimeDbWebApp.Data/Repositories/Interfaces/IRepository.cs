using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AnimeDbWebApp.Data.Repositories.Interfaces
{
    public interface IRepository : IDisposable
    {
        public void Add<T>(T entity) where T : class;
        public Task AddAsync<T>(T entity) where T : class;
        public void Remove<T>(T entity) where T : class;
        public T? Find<T, TT>(TT id) where T : class;
        public Task<T?> FindAsync<T, TT>(TT id) where T : class;
        public T? FirstOrDefault<T>(Func<T, bool> predicate) where T : class;
        public Task<T?> FirstOrDefaultAsync<T>(Expression<Func<T, bool>> predicate) where T : class;
        public IEnumerable<T> Where<T>(Func<T,bool> predicate) where T : class;
        public Task<IEnumerable<T>> WhereAsync<T>(Expression<Func<T, bool>> predicate) where T : class;
        public IEnumerable<T> All<T>() where T : class;
        public Task<IEnumerable<T>> AllAsync<T>() where T : class;
        public int SaveChanges<T>() where T : class;
        public Task<int> SaveChangesAsync<T>() where T : class;
    }
}