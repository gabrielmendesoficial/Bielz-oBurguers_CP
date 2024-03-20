using Microsoft.AspNetCore.Mvc;

namespace BielzãoBurguers_CP.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
