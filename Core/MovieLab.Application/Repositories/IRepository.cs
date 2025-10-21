using Microsoft.EntityFrameworkCore;
using MovieLab.Domain.Entities.Common;

namespace MovieLab.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
