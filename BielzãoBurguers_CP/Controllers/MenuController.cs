using Microsoft.AspNetCore.Mvc;

namespace BielzãoBurguers_CP.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View()   ;
        }
    }
}