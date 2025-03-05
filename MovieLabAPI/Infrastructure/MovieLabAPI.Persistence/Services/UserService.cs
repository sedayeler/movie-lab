using Microsoft.AspNetCore.Identity;
using MovieLabAPI.Application.Abstractions.Services;
using MovieLabAPI.Application.DTOs;
using MovieLabAPI.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLabAPI.Persistence.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;

        public UserService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            IdentityResult result = await _userManager.CreateAsync(new User()
            {
                Id = Guid.NewGuid().ToString(),
                FullName = request.FullName,
                UserName = request.Username,
                Email = request.Email
            }, request.Password);

            CreateUserResponse response = new CreateUserResponse()
            {
                Succeeded = result.Succeeded
            };

            if (result.Succeeded)
                response.Message = "User created successfully";
            else
                response.Message = string.Join(" | ", result.Errors.Select(e => e.Description));

            return response;
        }
    }
}
