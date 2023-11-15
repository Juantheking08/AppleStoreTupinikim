using Microsoft.AspNetCore.Mvc;

namespace AppleStoreTupinikim_.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Produto()
        {
            return View();
        }
    }
}
