using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieLabAPI.Application.Features.Commands.User.CreateUser;
using MovieLabAPI.Application.Features.Queries.User.GetAllUsers;
using MovieLabAPI.Application.Features.Queries.User.GetByIdUser;

namespace MovieLabAPI.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommandRequest request)
        {
            CreateUserCommandResponse response = await _mediator.Send(request);
            if (response.Succeeded)
                return Ok(response);
            else
                return BadRequest(response);
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllUsers(GetAllUsersQueryRequest request)
        {
            GetAllUsersQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetByIdUser([FromRoute] GetByIdUserRequest request)
        {
            GetByIdUserResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
