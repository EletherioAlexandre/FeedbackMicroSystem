using Microsoft.AspNetCore.Mvc;



namespace FeedbackMicroSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        // GET: api/<FeedbackController>
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }
    }
}
