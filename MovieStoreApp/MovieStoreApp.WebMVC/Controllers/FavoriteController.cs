using Microsoft.AspNetCore.Mvc;

namespace MovieStoreApp.WebMVC.Controllers
{
    public class FavoriteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
