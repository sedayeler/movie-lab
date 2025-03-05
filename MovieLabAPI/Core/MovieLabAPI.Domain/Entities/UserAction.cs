using MovieLabAPI.Domain.Entities.Common;
using MovieLabAPI.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLabAPI.Domain.Entities
{
    public class UserAction : BaseEntity
    {
        public bool IsFavorite { get; set; }
        public int? Rating { get; set; }
        public bool IsWatched { get; set; }
        public bool IsInWatchlist { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
