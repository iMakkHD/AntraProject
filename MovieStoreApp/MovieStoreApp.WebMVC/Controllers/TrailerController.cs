using Microsoft.AspNetCore.Mvc;

namespace MovieStoreApp.WebMVC.Controllers
{
    public class TrailerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
