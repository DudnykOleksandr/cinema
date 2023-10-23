using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheaterController : ControllerBase
    {
        public TheaterController(ILogger<TheaterController> logger) { 

        }
        [HttpGet]
        public IActionResult Get() { 

        }
    }
}
