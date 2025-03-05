using MovieLabAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLabAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task AddRangeAsync(List<T> entities);
        bool Update(T entity);
        bool Remove(T entity);
        Task<bool> RemoveAsync(Guid id);
        void RemoveRange(List<T> entities);
        Task<int> SaveAsync();
    }
}
