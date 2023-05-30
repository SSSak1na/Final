using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.Manage.Controllers
{
    public class HomeController : Controller
    {
        [Area("Manage")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
