using Microsoft.AspNetCore.Mvc;

namespace DemoGiihubActionDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            return Ok("hello this is testing from house ");
        }
    }
}
