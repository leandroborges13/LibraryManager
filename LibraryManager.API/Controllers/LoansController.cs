using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.API.Controllers
{
    [Route("api/loan")]
    [ApiController]
    public class LoansController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            var result = "";

            return Ok(result);
        }

        [HttpPut("{id}/return")]
        public IActionResult Return(int id)
        {
            return NoContent();
        }

    }
}
