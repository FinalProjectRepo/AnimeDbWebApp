using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Query;
using Azure;

namespace AnimeDbWebApp.Data.Repositories
{
    public class Repository(AnimeDbContext dbContext) : IRepository
    {
        protected AnimeDbContext _dbContext = dbContext;
        protected DbSet<T> DbSet<T>() where T : class => _dbContext.Set<T>();

        public int EntitiesCount<T>() where T : class => _dbContext.Set<T>().Count();
        public async Task<int> EntitiesCountAsync<T>() where T : class => await _dbContext.Set<T>().CountAsync();
        public void Add<T>(T entity) where T : class => DbSet<T>().Add(entity);
        public async Task AddAsync<T>(T entity) where T : class => await DbSet<T>().AddAsync(entity);
        public T? Find<T, TT>(TT id) where T : class => DbSet<T>().Find(id);
        public async Task<T?> FindAsync<T, TT>(TT id) where T : class => await DbSet<T>().FindAsync(id);
		public T? FirstOrDefault<T>(Func<T, bool> predicate) where T : class => DbSet<T>().FirstOrDefault(predicate);
        public async Task<T?> FirstOrDefaultAsync<T>(Expression<Func<T, bool>> predicate) where T : class
            => await DbSet<T>().FirstOrDefaultAsync(predicate);
		public T? FirstWithInclude<T>(Func<T, bool> predicate, Expression<Func<T, object>>[] includes)
			where T : class
		{
			if (includes.Length == 0) return FirstOrDefault<T>(predicate);
			DbSet<T> dbSet = DbSet<T>();
			IIncludableQueryable<T, object>? dbSetWithIncludes = null;
			for (var i = 0; i < includes.Length; i++)
			{
				Expression<Func<T, object>> include = includes[i];
				dbSetWithIncludes = dbSet.Include(include);
			}

			return dbSetWithIncludes!.FirstOrDefault(predicate);
		}
		public async Task<T?> FirstWithIncludeAsync<T>(Expression<Func<T, bool>> predicate, 
			Expression<Func<T, object>>[] includes) where T : class
		{
			if (includes.Length == 0) return await FirstOrDefaultAsync<T>(predicate);
			DbSet<T> dbSet = DbSet<T>();
			IIncludableQueryable<T, object>? dbSetWithIncludes = dbSet.Include(includes[0]);
			for (int i = 1; i < includes.Length; i++)
			{
				dbSetWithIncludes = dbSetWithIncludes.Include(includes[i]);
            }

            return await dbSetWithIncludes!.FirstAsync(predicate);
        }
		public IEnumerable<T> Where<T>(Func<T, bool> predicate) where T : class => [.. DbSet<T>().Where(x => predicate(x))];
        public async Task<IEnumerable<T>> WhereAsync<T>(Expression<Func<T, bool>> predicate) where T : class
            => await DbSet<T>().Where(predicate).ToArrayAsync();
        public IEnumerable<T> All<T>() where T : class => [.. DbSet<T>()];
        public async Task<IEnumerable<T>> AllAsync<T>() where T : class => await DbSet<T>().ToArrayAsync();
        public void Remove<T>(T entity) where T : class => DbSet<T>().Remove(entity);
        public Tuple<int, IEnumerable<T>> TakePage<T>(int items, int page, Expression<Func<T, bool>>? predicate = null, 
            params Expression<Func<T, object>>[] includes)
            where T : class
		{
			DbSet<T> dbSet = DbSet<T>();
			IQueryable<T> query;
			if (includes.Any())
			{
                IIncludableQueryable<T, object>? dbSetWithIncludes = dbSet.Include(includes[0]);
                for (var i = 1; i < includes.Length; i++)
                {
                    dbSetWithIncludes = dbSetWithIncludes.Include(includes[i]);
                }
                query = dbSetWithIncludes.Where(predicate ?? (x => true));
            }
            else query = dbSet.Where(predicate ?? (x => true));
			 

			int total = (query.Count() - 1) / items + 1;
			if (total < page) page = total;

			IEnumerable<T> collection = query.Skip((page - 1) * items).Take(items).ToArray();
			return Tuple.Create(total, collection);
		}

		public async Task<Tuple<int, IEnumerable<T>>> TakePageAsync<T>(int items, int page,
            Expression<Func<T, bool>>? predicate = null, params Expression<Func<T, object>>[] includes) 
            where T : class
		{
            DbSet<T> dbSet = DbSet<T>();
            IQueryable<T> query;
			if (includes.Any())
            {
                IIncludableQueryable<T, object>? dbSetWithIncludes = dbSet.Include(includes[0]);
                for (var i = 1; i < includes.Length; i++)
                {
                    dbSetWithIncludes = dbSetWithIncludes.Include(includes[i]);
                }
                query = dbSetWithIncludes.Where(predicate ?? (x => true));
            }
            else query = dbSet.Where(predicate ?? (x => true));

            int test = await query.CountAsync();
			int total = (await query.CountAsync() - 1) / items + 1;
            if (total < page) page = total;

			IEnumerable < T > collection = await query.Skip((page - 1) * items).Take(items).ToArrayAsync();
			return Tuple.Create(total, collection);
		}

        public int SaveChanges<T>() where T : class => _dbContext.SaveChanges();
        public Task<int> SaveChangesAsync<T>() where T : class => _dbContext.SaveChangesAsync();
        public void Dispose() => _dbContext.Dispose();
    }
}