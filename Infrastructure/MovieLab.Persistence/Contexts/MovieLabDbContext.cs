using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieLab.Domain.Entities;
using MovieLab.Domain.Entities.Common;

namespace MovieLab.Persistence.Contexts
{
    public class MovieLabDbContext : IdentityDbContext<User, Role, Guid>
    {
        public MovieLabDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> movies { get; set; }
        public DbSet<UserMovie> user_movies { get; set; }
        public DbSet<Review> reviews { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker
                .Entries<BaseEntity>()
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                    entry.Entity.CreatedAt = DateTime.UtcNow;

                if (entry.State == EntityState.Modified)
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
