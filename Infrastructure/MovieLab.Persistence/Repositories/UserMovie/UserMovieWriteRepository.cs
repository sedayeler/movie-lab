using MovieLab.Application.Repositories;
using MovieLab.Domain.Entities;
using MovieLab.Persistence.Contexts;

namespace MovieLab.Persistence.Repositories
{
    public class UserMovieWriteRepository : WriteRepository<UserMovie>, IUserMovieWriteRepository
    {
        public UserMovieWriteRepository(MovieLabDbContext context) : base(context)
        {
        }
    }
}
