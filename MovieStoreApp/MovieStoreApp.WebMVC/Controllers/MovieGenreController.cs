using Microsoft.AspNetCore.Mvc;

namespace MovieStoreApp.WebMVC.Controllers
{
    public class MovieGenreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
