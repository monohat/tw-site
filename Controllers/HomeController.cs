using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Shit()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
