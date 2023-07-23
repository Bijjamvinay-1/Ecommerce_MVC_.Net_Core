using Microsoft.AspNetCore.Mvc;

namespace MVC_ON_Ecomm_APP.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
