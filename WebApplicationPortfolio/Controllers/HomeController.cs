using Microsoft.AspNetCore.Mvc;

namespace WebApplicationPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
