using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLabAPI.Domain.Entities.Identity
{
    public class User : IdentityUser<string>
    {
        public string FullName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenEndDate { get; set; }
        public ICollection<UserAction> UserMovieActions { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
