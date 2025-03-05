using MediatR;
using MovieLabAPI.Application.Abstractions.Services;
using MovieLabAPI.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLabAPI.Application.Features.Commands.User.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        private readonly IUserService _userService;

        public CreateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            CreateUserResponse response = await _userService.CreateUserAsync(new CreateUserRequest()
            {
                FullName = request.FullName,
                Username = request.Username,
                Email = request.Email,
                Password = request.Password
            });

            return new CreateUserCommandResponse()
            {
                Succeeded = response.Succeeded,
                Message = response.Message
            };
        }
    }
}
