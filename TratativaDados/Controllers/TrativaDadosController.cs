using FeedbackMicroSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace TratativaDados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrativaDadosController : Controller
    {
        private readonly HttpClient _httpClient;

        public TrativaDadosController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpPost]
        public IActionResult TratativaDados(Feedback feedback)
        {
            

            return Ok();
        }
    }   
}
