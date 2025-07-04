using Microsoft.AspNetCore.Mvc;
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
            if (!ModelState.IsValid)
            {
                
                return View("Index", obj);
            }

            
            _operation.AddRequest(obj);
            _operation.SaveChanges();
            return View("RequestDone");
        }
    }
}
