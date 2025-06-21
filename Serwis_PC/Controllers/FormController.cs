using Microsoft.AspNetCore.Mvc;

namespace Serwis_PC.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
