using MovieLab.Application.Repositories;
using MovieLab.Domain.Entities;
using MovieLab.Persistence.Contexts;

namespace MovieLab.Persistence.Repositories
{
    public class MovieWriteRepository : WriteRepository<Movie>, IMovieWriteRepository
    {
        public MovieWriteRepository(MovieLabDbContext context) : base(context)
        {
        }
    }
}
