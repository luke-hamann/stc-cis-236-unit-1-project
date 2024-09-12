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
            if (ModelState.IsValid)
            {
                ViewBag.Volume = prism.Volume!.Value.ToString("n2");
                ViewBag.SurfaceArea = prism.SurfaceArea!.Value.ToString("n2");
                ViewBag.Diagonal = prism.Diagonal!.Value.ToString("n2");
            }

            return View(prism);
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }
    }
}
