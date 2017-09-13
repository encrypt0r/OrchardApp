using Microsoft.AspNetCore.Mvc;

namespace Module1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
