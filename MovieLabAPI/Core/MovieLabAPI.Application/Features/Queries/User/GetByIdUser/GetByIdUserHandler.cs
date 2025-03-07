using MediatR;
using MovieLabAPI.Application.Abstractions.Services;
using MovieLabAPI.Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLabAPI.Application.Features.Queries.User.GetByIdUser
{
    public class GetByIdUserHandler : IRequestHandler<GetByIdUserRequest, GetByIdUserResponse>
    {
        private readonly IUserService _userService;

        public GetByIdUserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<GetByIdUserResponse> Handle(GetByIdUserRequest request, CancellationToken cancellationToken)
        {
            ListUser user = await _userService.GetByIdUserAsync(request.Id);

            return new GetByIdUserResponse()
            {
                Id = user.Id,
                FullName = user.FullName,
                Username = user.Username,
                Email = user.Email
            };
        }
    }
}
