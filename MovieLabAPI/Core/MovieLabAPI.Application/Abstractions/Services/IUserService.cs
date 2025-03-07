using MovieLabAPI.Application.DTOs;
using MovieLabAPI.Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLabAPI.Application.Abstractions.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request);
        Task<List<ListUser>> GetAllUsersAsync();
        Task<ListUser> GetByIdUserAsync(string id);
    }
}
