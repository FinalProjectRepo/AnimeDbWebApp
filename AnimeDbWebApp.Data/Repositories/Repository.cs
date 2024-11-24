using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;

using AnimeDbWebApp.Data.Repositories.Interfaces;

namespace AnimeDbWebApp.Data.Repositories
{
    public class Repository(AnimeDbContext dbContext) : IRepository
    {
        protected DbContext _dbContext = dbContext;
        protected DbSet<T> DbSet<T>() where T : class => _dbContext.Set<T>();

        public int EntitiesCount<T>(Expression<Func<T, bool>>? predicate = null) where T : class 
			=> _dbContext.Set<T>().Where(predicate?? (x => true)).Count();
		public async Task<int> EntitiesCountAsync<T>(Expression<Func<T, bool>>? predicate = null) where T : class 
			=> await _dbContext.Set<T>().Where(predicate ?? (x => true)).CountAsync();
        public void Add<T>(T entity) where T : class => DbSet<T>().Add(entity);
        public async Task AddAsync<T>(T entity) where T : class => await DbSet<T>().AddAsync(entity);
		public void Remove<T>(T entity) where T : class => DbSet<T>().Remove(entity);
		public bool Any<T>(Expression<Func<T, bool>> predicate) where T : class => DbSet<T>().Any(predicate);
		public async Task<bool> AnyAsync<T>(Expression<Func<T, bool>> predicate)
			where T : class => await DbSet<T>().AnyAsync(predicate);
		public T? Find<T, TT>(TT id) where T : class => DbSet<T>().Find(id);
        public async Task<T?> FindAsync<T, TT>(TT id) where T : class => await DbSet<T>().FindAsync(id);
		public T? FirstOrDefault<T>(Func<T, bool> predicate) where T : class => DbSet<T>().FirstOrDefault(predicate);
        public async Task<T?> FirstOrDefaultAsync<T>(Expression<Func<T, bool>> predicate) where T : class
            => await DbSet<T>().FirstOrDefaultAsync(predicate);
		public T? FirstWithInclude<T>(Func<T, bool> predicate, string[] includes)
			where T : class
		{
			if (includes.Length == 0) return FirstOrDefault<T>(predicate);
			IQueryable<T> query = DbSet<T>();
			foreach (var include in includes)
			{
				query = query.Include(include);
			}

			return query.FirstOrDefault(predicate);
		}
		public async Task<T?> FirstWithIncludeAsync<T>(Expression<Func<T, bool>> predicate, 
			string[] includes) where T : class
		{
			if (includes.Length == 0) return await FirstOrDefaultAsync<T>(predicate);
            IQueryable<T> query = DbSet<T>();
			foreach (var include in includes)
			{
				query = query.Include(include);
            }

            return await query.FirstOrDefaultAsync(predicate);
        }
		public ICollection<T> Where<T>(Func<T, bool> predicate) where T : class => [.. DbSet<T>().Where(x => predicate(x))];
        public async Task<ICollection<T>> WhereAsync<T>(Expression<Func<T, bool>> predicate) where T : class
            => await DbSet<T>().Where(predicate).ToArrayAsync();
		public ICollection<T> WhereWithInclude<T>(Func<T, bool> predicate, string[] includes)
			where T : class
		{
			if (includes.Length == 0) return Where<T>(predicate);
			IQueryable<T> query = DbSet<T>();
			foreach (var include in includes)
			{
				query = query.Include(include);
			}

			return query.Where(predicate).ToArray();
		}
		public async Task<ICollection<T>> WhereWithIncludeAsync<T>(Expression<Func<T, bool>> predicate,
			string[] includes) where T : class
		{
			if (includes.Length == 0) return await WhereAsync<T>(predicate);
			IQueryable<T> query = DbSet<T>();
			foreach (var include in includes)
			{
				query = query.Include(include);
			}

			return await query.Where(predicate).ToArrayAsync();
		}
		public ICollection<T> All<T>() where T : class => [.. DbSet<T>()];
        public async Task<ICollection<T>> AllAsync<T>() where T : class => await DbSet<T>().ToArrayAsync();
        public Tuple<int, ICollection<T>> TakePage<T>(int items, int page, Expression<Func<T, bool>>? predicate = null, 
			params string[] includes) where T : class
		{
			IQueryable<T> query = DbSet<T>();
			foreach (var include in includes)
			{
				query = query.Include(include);
            }
            query = query.Where(predicate ?? (x => true));

			int total = (query.Count() - 1) / items + 1;
			if (total < page) page = total;

			ICollection<T> collection = query.Skip((page - 1) * items).Take(items).ToArray();
			return Tuple.Create(total, collection);
		}

		public async Task<Tuple<int, ICollection<T>>> TakePageAsync<T>(int items, int page,
            Expression<Func<T, bool>>? predicate = null, params string[] includes) 
            where T : class
		{
            IQueryable<T> query = DbSet<T>();
			foreach (var include in includes)
			{
				query = query.Include(include);
            }
            query = query.Where(predicate ?? (x => true));

            int test = await query.CountAsync();
			int total = (await query.CountAsync() - 1) / items + 1;
            if (total < page) page = total;

			ICollection< T > collection = await query.Skip((page - 1) * items).Take(items).ToArrayAsync();
			return Tuple.Create(total, collection);
		}

        public int SaveChanges<T>() where T : class => _dbContext.SaveChanges();
        public Task<int> SaveChangesAsync() => _dbContext.SaveChangesAsync();
        public void Dispose() => _dbContext.Dispose();
    }
}