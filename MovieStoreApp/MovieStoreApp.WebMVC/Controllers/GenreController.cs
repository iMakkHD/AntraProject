using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Services;

namespace MovieStoreApp.WebMVC.Controllers
{
    public class GenreController : Controller
    {
        IGenreServiceAsync genreService;
        IMovieGenreService movieGenreService;

        public GenreController(IGenreServiceAsync ser, IMovieGenreService service)
        {
            genreService = ser;
            movieGenreService = service;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "All Genres";

            return View();
        }
    }
}
