using MovieLabAPI.Domain.Entities.Common;
using MovieLabAPI.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLabAPI.Domain.Entities
{
    public class Review : BaseEntity
    {
        public string Content { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
