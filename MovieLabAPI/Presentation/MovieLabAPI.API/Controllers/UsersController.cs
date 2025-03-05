using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieLabAPI.Application.Abstractions.Services;
using MovieLabAPI.Application.Features.Commands.User.CreateUser;

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
    }
}
