using MovieLab.Application.Repositories;
using MovieLab.Domain.Entities;
using MovieLab.Persistence.Contexts;

namespace MovieLab.Persistence.Repositories
{
    public class UserMovieReadRepository : ReadRepository<UserMovie>, IUserMovieReadRepository
    {
        public UserMovieReadRepository(MovieLabDbContext context) : base(context)
        {
        }
    }
}
