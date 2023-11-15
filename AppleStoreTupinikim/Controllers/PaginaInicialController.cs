using Microsoft.AspNetCore.Mvc;

namespace AppleStoreTupinikim_.Controllers
{
    public class PaginaInicialController : Controller
    {
        public IActionResult PaginaInicial()
        {
            return View();
        }
    }
}
