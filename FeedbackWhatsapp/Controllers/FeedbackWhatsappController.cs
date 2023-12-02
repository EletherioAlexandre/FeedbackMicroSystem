using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;

namespace FeedbackWhatsapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackWhatsappController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        string apiKey = "YXBpTCZ2aWxsTzAhQCNtTW5nOy4sYS4=";

        public FeedbackWhatsappController()
        {
            _httpClient = new HttpClient();
        }

        [HttpPost]
        public async Task<IActionResult> PostToManager(string content)
        {
            var responseReceived = content;
            _httpClient.DefaultRequestHeaders.Add("apikey", apiKey);

            var responseToSend = await _httpClient.PostAsync("https://sender-api.levilo.com.br/message/sendText/agileTeam", 
                new StringContent(@"
                {
                  ""number"": ""5521973516340"",
                  // O options é opcional. Você pode não utilizar esse objeto.
                  ""options"": {
                    ""delay"": 5000, // Propriedade em millisegundos. 5000 = 5 segundos
                    ""presence"": ""paused"" // Composing = escrevendo... | recording = gravando audio... | paused = não exibir nenhum status
                  },
                  ""textMessage"": {
                    ""text"": ""VAMOS QUE VAMOS!""
                  }
                }
        ", Encoding.UTF8, "application/json"));
            return Ok();
        }
    }
}
