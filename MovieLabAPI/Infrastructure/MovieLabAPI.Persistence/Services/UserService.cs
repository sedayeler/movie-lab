using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MovieLabAPI.Application.Abstractions.Services;
using MovieLabAPI.Application.DTOs;
using MovieLabAPI.Application.DTOs.User;
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

        public async Task<List<ListUser>> GetAllUsersAsync()
        {
            List<User> users = await _userManager.Users.ToListAsync();
            return users.Select(u => new ListUser()
            {
                Id = u.Id,
                FullName = u.FullName,
                Username = u.UserName,
                Email = u.Email
            }).ToList();
        }

        public async Task<ListUser> GetByIdUserAsync(string id)
        {
            User? user = await _userManager.FindByIdAsync(id);
            if (user == null)
                throw new Exception("User not found");

            return new ListUser()
            {
                Id = user.Id,
                FullName = user.FullName,
                Username = user.UserName,
                Email = user.Email
            };
        }
    }
}
