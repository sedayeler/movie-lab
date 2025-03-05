using MovieLabAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLabAPI.Domain.Entities
{
    public class Movie : BaseEntity
    {
        public int TMDBId { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string PosterPath { get; set; }
        public float Rating { get; set; }
        public int VoteCount { get; set; }
        public ICollection<UserAction> UserMovieActions { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
