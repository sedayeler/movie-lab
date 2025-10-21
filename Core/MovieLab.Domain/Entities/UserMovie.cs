using MovieLab.Domain.Entities.Common;

namespace MovieLab.Domain.Entities
{
    public class UserMovie : BaseEntity
    {
        public int Rating { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }       
    }
}
