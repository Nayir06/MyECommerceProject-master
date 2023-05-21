using Microsoft.AspNetCore.Mvc;

namespace MVC_MyProject.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
