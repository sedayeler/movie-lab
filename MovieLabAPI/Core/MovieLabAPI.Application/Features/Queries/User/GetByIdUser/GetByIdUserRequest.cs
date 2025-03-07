using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLabAPI.Application.Features.Queries.User.GetByIdUser
{
    public class GetByIdUserRequest : IRequest<GetByIdUserResponse>
    {
        public string Id { get; set; }
    }
}
