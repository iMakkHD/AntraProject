using Microsoft.AspNetCore.Mvc;

namespace MovieStoreApp.WebMVC.Controllers
{
    public class PurchaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
