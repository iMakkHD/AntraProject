using Microsoft.AspNetCore.Mvc;

namespace MovieStoreApp.WebMVC.Controllers
{
    public class MovieCastController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
