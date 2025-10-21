using MovieLab.Domain.Entities.Common;

namespace MovieLab.Domain.Entities
{
    public class Review : BaseEntity
    {
        public string Content { get; set; } = string.Empty;

        public string UserId { get; set; }
        public User User { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }       
    }
}
