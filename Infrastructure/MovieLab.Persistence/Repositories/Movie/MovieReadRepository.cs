using MovieLab.Application.Repositories;
using MovieLab.Domain.Entities;
using MovieLab.Persistence.Contexts;

namespace MovieLab.Persistence.Repositories
{
    public class MovieReadRepository : ReadRepository<Movie>, IMovieReadRepository
    {
        public MovieReadRepository(MovieLabDbContext context) : base(context)
        {
        }
    }
}
