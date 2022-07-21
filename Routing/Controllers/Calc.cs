using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{
    public class Calc : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(int x, int y)
        {
            return View("Result", (float)(x + y));
        }

        public IActionResult Mul(int x, int y)
        {
            return View("Result", (float)(x * y));
        }

        public IActionResult Div(int x, int y)
        {
            if (y==0)
            {
                return RedirectToAction("Error");
            }
                return View("Result", (float)(x / y));
        }

        public IActionResult Sub(int x, int y)
        {
            return View("Result", (float)(x - y));
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
