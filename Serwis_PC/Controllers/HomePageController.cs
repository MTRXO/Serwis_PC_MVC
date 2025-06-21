using Microsoft.AspNetCore.Mvc;

namespace Serwis_PC.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
