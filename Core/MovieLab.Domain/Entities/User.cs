using Microsoft.AspNetCore.Identity;

namespace MovieLab.Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string? ProfilePictureUrl { get; set; }

        public ICollection<UserMovie> UserMovies { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
