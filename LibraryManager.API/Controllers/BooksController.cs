using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.API.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string search = "")
        {
            var result = "";

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
