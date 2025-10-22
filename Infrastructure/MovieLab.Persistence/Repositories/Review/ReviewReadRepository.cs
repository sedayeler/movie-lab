using MovieLab.Application.Repositories;
using MovieLab.Domain.Entities;
using MovieLab.Persistence.Contexts;

namespace MovieLab.Persistence.Repositories
{
    public class ReviewReadRepository : ReadRepository<Review>, IReviewReadRepository
    {
        public ReviewReadRepository(MovieLabDbContext context) : base(context)
        {
        }
    }
}
