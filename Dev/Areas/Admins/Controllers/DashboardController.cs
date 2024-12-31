using Microsoft.AspNetCore.Mvc;

namespace Dev.Areas.Admins.Controllers
{
    
    public class DashboardController : BaseController
    {



        public IActionResult Index()
        {
            return View();
        }


    }
}
