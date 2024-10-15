using LibraryManager.Application.Commands.LoginUser;
using LibraryManager.Application.Commands.UserCommands.InsertUser;
using LibraryManager.Application.Commands.UserCommands.UpdateUser;
using LibraryManager.Application.Queries.UserQuery.GetAllUser;
using LibraryManager.Application.Queries.UserQuery.GetUserById;
using LibraryManager.Application.Queries.UserQuery.GetUserDetailsById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace LibraryManager.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post(InsertUserCommand command)
        {
            var result = await _mediator.Send(command);

            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateUserCommand command)
        {
            var result = await _mediator.Send(command);

            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllUserQuery();
            var result = await _mediator.Send(query);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetUserByIdQuery(id));

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }

        [HttpPut("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginUserCommand command)
        {

            var result = await _mediator.Send(command);

            if (!result.IsSuccess)
            {
                return BadRequest("Não foi possível efetuar o login!");
            }

            return Ok(result);
        }
    }
}
