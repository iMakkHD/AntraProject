using Microsoft.AspNetCore.Mvc;

namespace MovieStoreApp.WebMVC.Controllers
{
    public class UserRoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
