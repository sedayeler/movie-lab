using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieLabAPI.Domain.Entities;
using MovieLabAPI.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLabAPI.Persistence.Contexts
{
    public class MovieLabAPIDbContext : IdentityDbContext<User, Role, string>
    {
        public MovieLabAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> movies { get; set; }
        public DbSet<UserAction> user_actions { get; set; }
        public DbSet<Review> reviews { get; set; }
    }
}
