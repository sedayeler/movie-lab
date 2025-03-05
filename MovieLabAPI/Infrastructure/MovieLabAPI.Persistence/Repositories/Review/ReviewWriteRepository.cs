using MovieLabAPI.Domain.Entities;
using MovieLabAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLabAPI.Persistence.Repositories
{
    public class ReviewWriteRepository : WriteRepository<Review>
    {
        public ReviewWriteRepository(MovieLabAPIDbContext context) : base(context)
        {
        }
    }
}
