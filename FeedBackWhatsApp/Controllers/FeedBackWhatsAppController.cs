using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class FeedBackWhastAppController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public FeedBackWhastAppController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] string content)
    {
      
        var response = await _httpClient.PostAsJsonAsync("https://sender-api.levilo.com.br/message/sendText/colocarnomedainstanciaaqui", content);
        if (!response.IsSuccessStatusCode)
        {
            return StatusCode((int)response.StatusCode);
        }

        return Ok();
    }
}
