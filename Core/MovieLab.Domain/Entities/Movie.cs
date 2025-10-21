using MovieLab.Domain.Entities.Common;

namespace MovieLab.Domain.Entities
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string? Overview { get; set; }
        public string? PosterPath { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public double? Popularity { get; set; }
        public string? Genre { get; set; }

        public ICollection<UserMovie> UserMovies { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
