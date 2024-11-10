using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using System.Linq;
using System.Linq.Expressions;

namespace AnimeDbWebApp.Data.Repositories
{
    public class Repository : IRepository
    {
        protected AnimeDbContext _dbContext;

        public Repository(AnimeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected DbSet<T> DbSet<T>() where T : class
        {
            return _dbContext.Set<T>();
        }

        public void Add<T>(T entity) where T : class
        {
            DbSet<T>().Add(entity);
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
            await DbSet<T>().AddAsync(entity);
        }

        public T? Find<T, TT>(TT id) where T : class
        {
            return DbSet<T>().Find(id);
        }

        public async Task<T?> FindAsync<T, TT>(TT id) where T : class
        {
            return await DbSet<T>().FindAsync(id);
        }
        public T? FirstOrDefault<T>(Func<T, bool> predicate) where T : class
        {
            return DbSet<T>().FirstOrDefault(predicate);
        }

        public async Task<T?> FirstOrDefaultAsync<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return await DbSet<T>().FirstOrDefaultAsync(predicate);
        }

        public IEnumerable<T> Where<T>(Func<T, bool> predicate) where T : class
        {
            return [.. DbSet<T>().Where(x => predicate(x))];
        }

        public async Task<IEnumerable<T>> WhereAsync<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return await DbSet<T>().Where(predicate).ToArrayAsync();
        }

        public IEnumerable<T> All<T>() where T : class
        {
            return [.. DbSet<T>()];
        }

        public async Task<IEnumerable<T>> AllAsync<T>() where T : class
        {
            return await DbSet<T>().ToArrayAsync();
        }

        public void Remove<T>(T entity) where T : class
        {
            DbSet<T>().Remove(entity);
        }

        public int SaveChanges<T>() where T : class
        {
            return _dbContext.SaveChanges();
        }

        public Task<int> SaveChangesAsync<T>() where T : class
        {
            return _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}