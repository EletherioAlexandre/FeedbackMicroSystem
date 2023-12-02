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
        string apiUrl = "http://localhost:5159/api/Feedback";
        private readonly string insightsApiUrl = "http://localhost:5201/api/FeedbackWhatsapp";

        public TrativaDadosController()
        {
            _httpClient = new HttpClient();
        }

        [HttpGet]
        public async Task <IActionResult> ConsultaDados()
        {
            var response = await _httpClient.GetAsync(apiUrl);

            // trataria os dados com a Inteligência Artificial, retornaria a string abaixo:

            string insightsText = @"
            Analisando os feedbacks fornecidos, alguns insights generalistas podem ser extraídos para orientar melhorias gerais nos atendimentos da loja:

            1. **Eficiência na Entrega:**
               - Há indicações de que o tempo de entrega pode ser aprimorado, com um feedback mencionando uma demora além do esperado. Investir em otimizações nos processos logísticos pode contribuir para uma experiência de entrega mais rápida e eficiente.

            2. **Qualidade da Embalagem:**
               - A qualidade das embalagens é crucial, como evidenciado por um feedback mencionando danos na embalagem. Melhorias na resistência e segurança das embalagens podem garantir que os alimentos cheguem aos clientes em condições ideais, impactando positivamente na percepção geral.

            3. **Variedade e Aparência dos Produtos:**
               - Clientes valorizam diferentes aspectos da comida, como sabor e boa aparência. Ampliar a variedade de opções no menu e garantir uma apresentação visual atraente podem atender a diversas preferências dos clientes, contribuindo para uma experiência gastronômica mais satisfatória.

            4. **Avaliação Geral da Comida:**
               - A pontuação média das avaliações é positiva, mas há espaço para aprimoramentos contínuos. Monitorar a qualidade dos ingredientes, ajustar receitas conforme necessário e incentivar feedback mais detalhado sobre a experiência gastronômica podem elevar ainda mais a satisfação dos clientes.

            5. **Experiência de Entrega Consistente:**
               - A consistência na experiência de entrega é crucial. Enquanto alguns clientes expressaram satisfação, outros relataram insatisfação. Investir em uma logística de entrega confiável e identificar e resolver possíveis desafios pode contribuir para uma experiência de entrega mais uniforme e positiva.

            6. **Diversidade nas Respostas das Pesquisas:**
               - As respostas nas pesquisas revelam uma diversidade de preferências dos clientes. Utilizar essas informações para ajustar estratégias, seja no menu ou nos serviços, pode criar uma oferta mais alinhada com as expectativas variadas dos clientes.

            Em resumo, a loja pode aprimorar sua eficiência na entrega, investir na qualidade da embalagem, diversificar o menu e garantir uma apresentação visual atraente. Monitorar continuamente a qualidade dos alimentos e a experiência de entrega, além de utilizar feedbacks específicos para orientar melhorias, são abordagens estratégicas para elevar a satisfação geral dos clientes.";

            var insightsResponse = await _httpClient.PostAsync(insightsApiUrl, new StringContent(insightsText));

            return Ok(response);
        }
    }   
}
