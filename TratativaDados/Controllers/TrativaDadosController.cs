using Microsoft.AspNetCore.Mvc;

namespace TratativaDados.Controllers
{
    public class TrativaDadosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
