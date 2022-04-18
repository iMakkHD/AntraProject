using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Models;
using MovieStoreApp.WebMVC.Models;

namespace MovieStoreApp.WebMVC.Controllers
{
    //[Route("cast")]
    public class CastController : Controller
    {
        private readonly ICastServiceAsync castServiceAsync;
        public CastController(ICastServiceAsync _castServiceAsync)
        {
            castServiceAsync = _castServiceAsync;
        }
        // [Route("list")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("add")]
        public IActionResult Create()
        {
            ViewBag.Gender = new SelectList(GetGenders(), "Id", "Gender");
            return View();
        }
        [NonAction]
        private IEnumerable<GenderModel> GetGenders()
        {
            return new List<GenderModel>() {
             new GenderModel(){ Id=1, Gender="Male"},

             new GenderModel(){ Id=2, Gender="Female"}
            };
        }

        [HttpPost]
        public IActionResult Create(CastModel model)
        {

            ViewBag.Gender = new SelectList(GetGenders(), "Id", "Gender");
            if (model.ProfilePath != null)
            {
                castServiceAsync.AddCastAsync(model);
                return RedirectToAction("Index");
            }
            //call the service to insert the data

            return View(model);
        }
    }
}
