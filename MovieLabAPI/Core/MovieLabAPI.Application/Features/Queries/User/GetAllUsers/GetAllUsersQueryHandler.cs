using MediatR;
using MovieLabAPI.Application.Abstractions.Services;
using MovieLabAPI.Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLabAPI.Application.Features.Queries.User.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQueryRequest, GetAllUsersQueryResponse>
    {
        private readonly IUserService _userService;

        public GetAllUsersQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<GetAllUsersQueryResponse> Handle(GetAllUsersQueryRequest request, CancellationToken cancellationToken)
        {
            List<ListUser> users = await _userService.GetAllUsersAsync();

            return new GetAllUsersQueryResponse()
            {
                Users = users,
                TotalUsers = users.Count
            };
        }
    }
}
