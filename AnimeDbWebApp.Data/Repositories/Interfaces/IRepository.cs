using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnimeDbWebApp.Data.Repositories.Interfaces
{
    public interface IRepository
    {
        public void Add<T>(T entity) where T : class;
        public Task AddAsync<T>(T entity) where T : class;
        public void Remove<T>(T entity) where T : class;
        public T? Find<T>(object id) where T : class;
        public Task<T?> FindAsync<T>(object id) where T : class;
        public T? FirstOrDefault<T>(Func<bool> predicate) where T : class;
        public Task<T?> FirstOrDefaultAsync<T>(Func<bool> predicate) where T : class;
        public IEnumerable<T> Where<T>(Func<bool> predicate) where T : class;
        public Task<IEnumerable<T>> WhereAsync<T>(Func<bool> predicate) where T : class;
        public IEnumerable<T> All<T>() where T : class;
        public Task<IEnumerable<T>> AllAsync<T>() where T : class;
        public int SaveChanges<T>() where T : class;
        public Task<int> SaveChangesAsync<T>() where T : class;
    }
}