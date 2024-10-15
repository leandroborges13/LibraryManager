using LibraryManager.Application.Commands.LoanCommands.InsertLoan;
using LibraryManager.Application.Commands.LoanCommands.ReturnLoan;
using LibraryManager.Application.Queries.LoanQuery;
using LibraryManager.Application.Queries.UserQuery.GetAllUser;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.API.Controllers
{
    [Route("api/loan")]
    [ApiController]
    [Authorize]
    public class LoansController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LoansController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post(InsertLoanCommand command)
        {
            var result = await _mediator.Send(command);

            return NoContent();
        }

        [HttpPut("{id}/return")]
        public async Task<IActionResult> Return(ReturnLoanCommand command)
        {
            var result = await _mediator.Send(command);

            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllLoanQuery();
            var result = await _mediator.Send(query);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }

    }
}
