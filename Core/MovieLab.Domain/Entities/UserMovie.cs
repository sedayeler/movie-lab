namespace MovieLab.Domain.Entities
{
    public class UserMovie 
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }

        public int Rating { get; set; } 
        public DateTime WatchedDate { get; set; } = DateTime.UtcNow;
    }
}
