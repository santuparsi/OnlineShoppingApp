using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShoppingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("Sample API is working!");
        }
        public IActionResult Put()
        {
            return Ok("Sample API received a PUT request!");
        }
        public IActionResult Post()
        {
            return Ok("Post Request");
        }
    }
}
