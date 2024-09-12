using Microsoft.AspNetCore.Mvc;
using RectangularPrismCalculator.Models;

namespace RectangularPrismCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RectangularPrism prism)
        {
            return View(prism);
        }
    }
}
