using LibraryManager.Application.Queries.BookQuery;
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
        public IActionResult GetById(int id)
        {
            var result = "";

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = "";

            return NoContent();
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
