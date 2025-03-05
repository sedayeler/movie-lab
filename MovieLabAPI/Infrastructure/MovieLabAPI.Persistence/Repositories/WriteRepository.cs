using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using MovieLabAPI.Application.Repositories;
using MovieLabAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieLabAPI.Persistence.Contexts;

namespace MovieLabAPI.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly MovieLabAPIDbContext _context;

        public WriteRepository(MovieLabAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public async Task AddRangeAsync(List<T> entities)
        {
            await Table.AddRangeAsync(entities);
        }

        public bool Update(T entity)
        {
            EntityEntry<T> entityEntry = Table.Update(entity);
            return entityEntry.State == EntityState.Modified;
        }

        public bool Remove(T entity)
        {
            EntityEntry<T> entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            T entity = await Table.SingleOrDefaultAsync(b => b.Id == id);
            return Remove(entity);
        }

        public void RemoveRange(List<T> entities)
        {
            Table.RemoveRange(entities);
        }

        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();
    }
}
