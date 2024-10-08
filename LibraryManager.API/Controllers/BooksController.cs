using LibraryManager.Application.Commands.BookCommands.DeleteBook;
using LibraryManager.Application.Queries.BookQuery;
using LibraryManager.Application.Queries.BookQuery.GetBookById;
using LibraryManager.Application.Queries.UserQuery.GetAllUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.API.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(string search = "")
        {
            var query = new GetAllBookQuery();
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
            var query = new GetBookByIdQuery(id);
            var result = await _mediator.Send(query);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var cmd = new DeleteBookCommand(id);
            var result = await _mediator.Send(cmd);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post()
        {
            var result = "";

            return Ok(result);
        }

        [HttpPut]
        public IActionResult Put()
        {
            var result = "";

            return NoContent();
        }
    }
}
