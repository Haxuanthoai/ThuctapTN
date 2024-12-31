using Microsoft.AspNetCore.Mvc;

namespace Dev.Controllers
{
    public class AboutusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
