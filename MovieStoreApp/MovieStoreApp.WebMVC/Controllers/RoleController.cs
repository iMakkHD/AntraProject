using Microsoft.AspNetCore.Mvc;

namespace MovieStoreApp.WebMVC.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
