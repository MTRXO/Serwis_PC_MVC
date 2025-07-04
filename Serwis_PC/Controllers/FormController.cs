using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using SerwisDataAccess.Repository;
using SerwisModels;

namespace Serwis_PC.Controllers
{
    public class FormController : Controller
    {
        private readonly IDbOperations<RequestModel> _operation;

        public FormController(IDbOperations<RequestModel> operation)
        {
            _operation = operation;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RequestModel obj)
        {

            if (int.TryParse(obj.PhoneNumber, out int result))
            {
                _operation.AddRequest(obj);
                _operation.SaveChanges();
                return View("RequestDone");
            }

            else
            {
                ModelState.AddModelError("PhoneNumber", "Numer telefonu musi składać sie z samych cyfr ");
                return View("Index");
            }
            


        }


    }
}
